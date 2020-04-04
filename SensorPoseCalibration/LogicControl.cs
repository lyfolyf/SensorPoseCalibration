using CommonStruct.Type3D;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SensorPoseCalibration
{
    public class LogicControl
    {
        public ParamManager paramManager;
        IntPtr poseCalibAlgo;
        public static EventHandler OnPointCloudListChanged;
        public static EventHandler OnPointCloudColorChanged;

        public LogicControl()
        {
            paramManager = new ParamManager();
            poseCalibAlgo = PoseCalibDLL.CreatePoseCalibInstance();
        }

        public bool CalibrateSensorPose(out Dictionary<PointCloudInfo, XDPOINT[,]> srcPointCloudDic, out Dictionary<PointCloudInfo, XDPOINT[,]> desPointCloudDic,out string errCode)
        {
            errCode = string.Empty;
            srcPointCloudDic = new Dictionary<PointCloudInfo, XDPOINT[,]>();
            desPointCloudDic = new Dictionary<PointCloudInfo, XDPOINT[,]>();
            PoseCalibrationParam calibParam = paramManager.GetSelectedParam();
            List<PointCloudInfo> pointCloudLst = calibParam.PointCloudParams.PointCloudInfoLst;
            if (pointCloudLst.FindAll(p => string.IsNullOrEmpty(p.PointCloudPath.pathName) || !File.Exists(p.PointCloudPath.pathName)).Count > 0)
            {
                errCode = "点云" + pointCloudLst.FindIndex(p => string.IsNullOrEmpty(p.PointCloudPath.pathName) || !File.Exists(p.PointCloudPath.pathName)) + "路径未设置或不存在";
                return false;
            }
            foreach(var item in pointCloudLst)
            {
                XDPOINT[,] points;
                if (item.IsPointArray)
                {
                    if (!ReadPointArray(item, out points))
                    {
                        errCode = "点云" + pointCloudLst.FindIndex(p => p == item) + "读取失败";
                        return false;
                    }
                    srcPointCloudDic[item] = points;
                }
                else
                {
                    if (!ReadPointLine(item, out points))
                    {
                        errCode = "点云" + pointCloudLst.FindIndex(p => p == item) + "读取失败";
                        return false;
                    }
                    srcPointCloudDic[item] = points;
                }
            }
            foreach (var item in pointCloudLst)
            {
                int rows = srcPointCloudDic[item].GetLength(0);
                int columns = srcPointCloudDic[item].GetLength(1);
                XDPOINT[] pointArray = new XDPOINT[rows * columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        pointArray[j + i * columns] = srcPointCloudDic[item][i, j];
                    }
                }
                if (!PoseCalibDLL.AddPointCloud(poseCalibAlgo, ref pointArray[0], pointArray.Length))
                {
                    errCode = "AddPointCloud Error";
                    return false;
                }

                double[] Axis_Pos = { item.XPosition, item.YPosition, item.ZPosition };
                if (!PoseCalibDLL.AddTrajInfo(poseCalibAlgo, ref Axis_Pos[0], Axis_Pos.Length))
                {
                    errCode = "AddTrajInfo Error";
                    return false;
                }
            }
            PoseCalibDLL.SetInitPose(poseCalibAlgo, calibParam.InitAngleX, calibParam.InitAngleY, calibParam.InitAngleZ);

            PoseCalibDLL.AddSensorMoveAxis(poseCalibAlgo, 2);
            PoseCalibDLL.SetScanMoveAxis(poseCalibAlgo, 0);
            PoseCalibDLL.SetAxisDir(poseCalibAlgo, 0, true);
            PoseCalibDLL.SetAxisDir(poseCalibAlgo, 1, false);
            PoseCalibDLL.SetAxisDir(poseCalibAlgo, 2, true);
            PoseCalibDLL.SetSensorLineDir(poseCalibAlgo, true);

            double[] result_pose = { 0.0, 0.0, 0.0 };
            double final_cost = 0;
            if (!PoseCalibDLL.ComputeSensorPose(poseCalibAlgo, ref result_pose[0], ref final_cost))
            {
                errCode = "ComputeSensorPose Error";
                return false;
            }
            calibParam.CalibResult.FinalCost = final_cost;
            calibParam.CalibResult.ResultAngleX = result_pose[0];
            calibParam.CalibResult.ResultAngleY = result_pose[1];
            calibParam.CalibResult.ResultAngleZ = result_pose[2];
            
            foreach (var item in pointCloudLst)
            {
                int index = pointCloudLst.FindIndex(p => p == item);
                int nums = PoseCalibDLL.GetSinglePointCloudNum(poseCalibAlgo, index);
                XDPOINT[] resultArray = new XDPOINT[nums];
                PoseCalibDLL.GetTransedPointCloud(poseCalibAlgo, index, ref resultArray[0]);
                XDPOINT[,] points = new XDPOINT[nums,1];
                for (int i = 0; i < nums; i++)
                    points[i, 0] = resultArray[i];
                desPointCloudDic[item] = points;
            }
            return true;
        }

        private bool ReadPointArray(PointCloudInfo param, out XDPOINT[,] points)
        {
            int rows, columns;
            points = new XDPOINT[0,0];
            using (FileStream fs = new FileStream(param.PointCloudPath.pathName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string[] dataTemp = sr.ReadToEnd().Split('\n');
                if (dataTemp == null)
                {
                    return false;
                }
                rows = string.IsNullOrEmpty(dataTemp[dataTemp.Length - 1]) ? dataTemp.Length - 1 : dataTemp.Length;
                sr.Close();
                fs.Close();
            }
            int pointChildNum = param.IsIncludeIntensity ? 4 : 3;
            using (FileStream fs = new FileStream(param.PointCloudPath.pathName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                StreamReader sr = new StreamReader(fs);
                sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                char separator = ',';
                string lineData = sr.ReadLine();
                string[] info = lineData.Split(separator);
                columns = info.Length / pointChildNum;
                if (columns == 0)
                {
                    separator = '\t';
                    info = lineData.Split(separator);
                    columns = info.Length / pointChildNum;
                }
                if (columns == 0)
                {
                    separator = ';';
                    info = lineData.Split(separator);
                    columns = info.Length / pointChildNum;
                }
                if (columns == 0)
                {
                    separator = ' ';
                    info = lineData.Split(separator);
                    columns = info.Length / pointChildNum;
                }
                if (columns == 0)
                {
                    return false;
                }
                #region 读取XDPOINT数据
                points = new XDPOINT[rows, columns];
                int i = 0;
                try
                {
                    while (info != null)
                    {
                        if (i > (points.GetLength(0) - 1))
                        {
                            break;
                        }
                        for (int j = 0; j < info.Length; j++)
                        {
                            if (info[j] == "") continue;
                            XDPOINT tempPoint = new XDPOINT();

                            tempPoint.x = Convert.ToDouble(info[j]); j++;
                            tempPoint.y = Convert.ToDouble(info[j]); j++;

                            if (Convert.ToDouble(info[j]) > param.ZMax || Convert.ToDouble(info[j]) < param.ZMin)
                            {
                                tempPoint.z = double.NaN;
                            }
                            else
                            {
                                tempPoint.z = Convert.ToDouble(info[j]);
                            }
                            if (param.IsIncludeIntensity)
                            {
                                j++;
                            }

                            points[i, (j + 1) / pointChildNum - 1] = tempPoint;
                        }
                        if (i >= (points.GetLength(0) - 1))
                        {
                            break;
                        }
                        try
                        {
                            info = sr.ReadLine().Split(separator);
                        }
                        catch (Exception ex)
                        {
                            string error= ex.Message;
                            break;
                        }
                        i++;
                    }
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
                #endregion
            }
            return true;
        }

        private bool ReadPointLine(PointCloudInfo param, out XDPOINT[,] points)
        {
            int columns;
            points = new XDPOINT[0, 0];

            int pointChildNum = param.IsIncludeIntensity ? 4 : 3;
            using (FileStream fs = new FileStream(param.PointCloudPath.pathName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                StreamReader sr = new StreamReader(fs);
                sr = new StreamReader(fs);
                char separator = ',';
                string lineData = sr.ReadLine();
                string[] info = lineData.Split(separator);
                columns = info.Length / pointChildNum;
                if (columns == 0)
                {
                    separator = '\t';
                    info = lineData.Split(separator);
                    columns = info.Length / pointChildNum;
                }
                if (columns == 0)
                {
                    separator = ';';
                    info = lineData.Split(separator);
                    columns = info.Length / pointChildNum;
                }
                if (columns == 0)
                {
                    separator = ' ';
                    info = lineData.Split(separator);
                    columns = info.Length / pointChildNum;
                }
                if (columns == 0)
                {
                    return false;
                }
                #region 读取XDPOINT数据
                List<XDPOINT> pointLine = new List<XDPOINT>();
                try
                {
                    while (info != null)
                    {
                        for (int j = 0; j < info.Length; j++)
                        {
                            if (info[j] == "") continue;
                            XDPOINT tempPoint = new XDPOINT();
                            tempPoint.x = Convert.ToDouble(info[j]); j++;
                            tempPoint.y = Convert.ToDouble(info[j]); j++;

                            if (Convert.ToDouble(info[j]) > param.ZMax || Convert.ToDouble(info[j]) < param.ZMin)
                            {
                                tempPoint.z = double.NaN;
                            }
                            else
                            {
                                tempPoint.z = Convert.ToDouble(info[j]);
                            }

                            if (param.IsIncludeIntensity)
                            {
                                j++;
                            }
                            pointLine.Add(tempPoint);
                        }
                        try
                        {
                            info = sr.ReadLine().Split(separator);
                        }
                        catch (Exception ex)
                        {
                            string error = ex.Message;
                            break;
                        }
                    }
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
                points = new XDPOINT[pointLine.Count, 1];
                for (int i = 0; i < pointLine.Count; i++)
                {
                    points[i, 0] = pointLine[i];
                }
                #endregion
            }
            return true;
        }
        
        public bool SaveResultPose()
        {
            PoseCalibrationParam calibParam = paramManager.GetSelectedParam();
            return PoseCalibDLL.SavePoseMatrix(poseCalibAlgo, calibParam.CalibResult.SavePath.pathName,
                calibParam.CalibResult.TranslationX, calibParam.CalibResult.TranslationY, calibParam.CalibResult.TranslationZ);
        }

    }

    class PoseCalibDLL
    {
        //****************************************************************************
        //  

        //  主程序初始化时调用，得到一个全局的IntPtr，便于后续调用
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CreatePoseCalibInstance();

        // 主程序退出时，删除全局的IntPtr, 释放资源
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyPoseCalibInstance(IntPtr pInstance);


        //****************************************************************************
        //  求解姿态界面中相关的函数 
        //
        // 读取点云后，添加到pInstance中，目前5条依次添加
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool AddPointCloud(IntPtr pInstance, ref XDPOINT pts, int num);


        // 读取用户设置的各条轨迹x, y, z轴数据后，依次添加，须与AddPointCloud中一一对应
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool AddTrajInfo(IntPtr pInstance, ref double pts, int num);


        // 添加用户设置的初始姿态，单位为度
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetInitPose(IntPtr pInstance, double x, double y, double z);



        // 计算传感器姿态，返回姿态及final_cost
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ComputeSensorPose(IntPtr pInstance, ref double pose_array, ref double final_cost);




        //****************************************************************************
        //  机台设置界面中相关的函数 
        //  

        // 传感器运动轴设定，axis_index表示轴索引，0表示x轴， 1表示y轴， 2表示z轴
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddSensorMoveAxis(IntPtr pInstance, int axis_index);


        // 扫描方向设定，axis_index表示轴索引，0表示x轴， 1表示y轴
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetScanMoveAxis(IntPtr pInstance, int axis_index);


        // 运动轴正向设定， axis_index为轴索引， 0表示x轴， 1表示y轴， 2表示z轴
        // is_positive表示是否正向， x轴向右为正向， y轴向里为正向， z轴向上为正向
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetAxisDir(IntPtr pInstance, int axis_index, bool is_positive);


        // 添加用户设置的是否翻转扫描线数据
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetSensorLineDir(IntPtr pInstance, bool isPositive);


        //****************************************************************************
        // 保存矩阵
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SavePoseMatrix(IntPtr pInstance, [MarshalAs(UnmanagedType.LPStr)]string file_name, double trans_x, double trans_y, double trans_z);


        // 得到单条变换后的点云
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool GetTransedPointCloud(IntPtr pInstance, int index, ref XDPOINT pts);

        // 得到点云的点数
        [DllImport("GC_ALGO.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSinglePointCloudNum(IntPtr pInstance, int index);
    }
}
