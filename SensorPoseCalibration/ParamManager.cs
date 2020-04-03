using CommonStruct.Type3D;
using ComponentLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SensorPoseCalibration
{
    public class ParamManager
    {
        static Type[] types = new Type[] { typeof(PoseCalibrationParam), typeof(PoseCalibrationResult), typeof(PointCloudParam), typeof(PointCloudInfo), typeof(SaveFilePath), typeof(OpenFilePath) };

        private Dictionary<string, PoseCalibrationParam> _poseParamDic;

        public ParamManager()
        {
            _poseParamDic = new Dictionary<string, PoseCalibrationParam>();
        }

        public bool LoadParams(string path)
        {
            List<PoseCalibrationParam> paramLst = DeserializeFromXml<List<PoseCalibrationParam>>(path, types) as List<PoseCalibrationParam>;
            if (paramLst == default(List<PoseCalibrationParam>))
                return false;
            _poseParamDic = paramLst.ToDictionary(p => p.Name, p => p);
            return true;;
        }
        
        private T DeserializeFromXml<T>(string filePath, Type[] types)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return default(T);
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(T), types);
                    T ret = (T)xs.Deserialize(reader);
                    return ret;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return default(T);
            }
        }

        public bool SaveParams(string path)
        {
            return SerializeToXml(path, _poseParamDic.Values.ToList(), types);
        }

        private bool SerializeToXml<T>(string filePath, T obj, Type[] xao)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    StreamWriter writer = new StreamWriter(fs);
                    XmlSerializer xs = new XmlSerializer(typeof(T), xao);
                    xs.Serialize(writer, obj);

                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return false;
            }

            return true;
        }

        public PoseCalibrationParam GetSelectedParam()
        {
            return _poseParamDic.Values.ToList().Find(p => p.IsConfig);
        }

        public void SetSelectedParam(string name)
        {
            if(_poseParamDic.Keys.Contains(name))
            {
                _poseParamDic = _poseParamDic.ToDictionary(p=>p.Key,p=> new PoseCalibrationParam(p.Value) { IsConfig = (p.Key == name) });
            }
        }

        public bool AddParam(string name)
        {
            if (_poseParamDic.Keys.Contains(name))
                return false;
            _poseParamDic[name] = new PoseCalibrationParam();
            _poseParamDic[name].Name = name;
            return true;
        }

        public bool RemoveParam(string name)
        {
            if (!_poseParamDic.Keys.Contains(name))
                return false;
            _poseParamDic.Remove(name);
            return true;
        }

        public List<string> GetAllParamNames()
        {
            return _poseParamDic.Keys.ToList();
        }
    }

    public class PoseCalibrationParam
    {
        [Category("点云")]
        [DisplayName("点云数据")]
        [Description("设置点云参数")]
        [PropertyGridEx.PropertyOrder(0)]
        public PointCloudParam PointCloudParams { get; set; }

        [Category("初始值")]
        [DisplayName("X夹角")]
        [Description("设置X夹角")]
        [PropertyGridEx.PropertyOrder(1)]
        public double InitAngleX { get; set; }

        [Category("初始值")]
        [DisplayName("Y夹角")]
        [Description("设置Y夹角")]
        [PropertyGridEx.PropertyOrder(2)]
        public double InitAngleY { get; set; }

        [Category("初始值")]
        [DisplayName("Z夹角")]
        [Description("设置Z夹角")]
        [PropertyGridEx.PropertyOrder(3)]
        public double InitAngleZ { get; set; }
                
        [Browsable(false)]
        public string Name { get; set; }

        [Browsable(false)]
        public bool IsConfig { get; set; }

        [Browsable(false)]
        public PoseCalibrationResult CalibResult { get; set; }
        public PoseCalibrationParam()
        {
            PointCloudParams = new PointCloudParam();
            CalibResult = new PoseCalibrationResult();
        }

        public PoseCalibrationParam(PoseCalibrationParam param)
        {
            this.PointCloudParams = param.PointCloudParams;
            this.InitAngleX = param.InitAngleX;
            this.InitAngleY = param.InitAngleY;
            this.InitAngleZ = param.InitAngleZ;
            this.CalibResult = param.CalibResult;
            this.Name = param.Name;
            this.IsConfig = param.IsConfig;
        }
    }

    public class PoseCalibrationResult
    {
        [Category("输出")]
        [DisplayName("残差")]
        [Description("输出残差结果")]
        [ReadOnly(true)]
        [PropertyGridEx.PropertyOrder(0)]
        public double FinalCost { get; set; }

        [Category("输出")]
        [DisplayName("X夹角")]
        [Description("输出X夹角结果")]
        [ReadOnly(true)]
        [PropertyGridEx.PropertyOrder(1)]
        public double ResultAngleX { get; set; }

        [Category("输出")]
        [DisplayName("Y夹角")]
        [Description("输出Y夹角结果")]
        [ReadOnly(true)]
        [PropertyGridEx.PropertyOrder(2)]
        public double ResultAngleY { get; set; }

        [Category("输出")]
        [DisplayName("Z夹角")]
        [Description("输出Z夹角结果")]
        [ReadOnly(true)]
        [PropertyGridEx.PropertyOrder(3)]
        public double ResultAngleZ { get; set; }

        [Category("保存姿态")]
        [DisplayName("路径")]
        [Description("设置保存路径")]
        [PropertyGridEx.PropertyOrder(4)]
        public SaveFilePath SavePath { get; set; }

        [Category("保存姿态")]
        [DisplayName("X平移")]
        [Description("设置X轴平移量")]
        [PropertyGridEx.PropertyOrder(5)]
        public double TranslationX { get; set; }

        [Category("保存姿态")]
        [DisplayName("Y平移")]
        [Description("设置Y轴平移量")]
        [PropertyGridEx.PropertyOrder(6)]
        public double TranslationY { get; set; }

        [Category("保存姿态")]
        [DisplayName("Z平移")]
        [Description("设置Z轴平移量")]
        [PropertyGridEx.PropertyOrder(7)]
        public double TranslationZ { get; set; }

        public PoseCalibrationResult()
        {
            SavePath = new SaveFilePath();
        }

    }

    public class OpenFilePath : PropertyGridEx.IPropertyFormEditBase
    {
        public string pathName;
        public void SetValue()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PointCloud File|*.txt;*.csv";
            if (openFile.ShowDialog() == DialogResult.OK)
                pathName = openFile.FileName;
        }

        public OpenFilePath()
        {
            pathName = string.Empty;
        }

        public override string ToString()
        {
            return pathName;
        }
    }

    public class SaveFilePath : PropertyGridEx.IPropertyFormEditBase
    {
        public string pathName;
        public void SetValue()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Save File|*.txt;*.csv";
            if (saveFile.ShowDialog() == DialogResult.OK)
                pathName = saveFile.FileName;
        }

        public SaveFilePath()
        {
            pathName = string.Empty;
        }

        public override string ToString()
        {
            return pathName;
        }
    }

    public class PointCloudInfo : ICloneable
    {
        [Category("点云")]
        [DisplayName("路径")]
        [Description("设置点云路径")]
        [ReadOnly(false)]
        [PropertyGridEx.PropertyOrder(0)]
        public OpenFilePath PointCloudPath { get; set; }

        [Category("点云")]
        [DisplayName("阵列数据")]
        [Description("设置点云是否为阵列数据")]
        [PropertyGridEx.PropertyOrder(1)]
        public bool IsPointArray { get; set; }

        [Category("点云")]
        [DisplayName("光强")]
        [Description("设置点云数据是否包含光强")]
        [PropertyGridEx.PropertyOrder(2)]
        public bool IsIncludeIntensity { get; set; }

        [Category("点云")]
        [DisplayName("Z最大值")]
        [Description("设置Z最大值")]
        [PropertyGridEx.PropertyOrder(3)]
        public double ZMax { get; set; }

        [Category("点云")]
        [DisplayName("Z最小值")]
        [Description("设置Z最小值")]
        [PropertyGridEx.PropertyOrder(4)]
        public double ZMin { get; set; }

        [Category("扫描初始位置")]
        [DisplayName("X轴坐标")]
        [Description("设置X轴坐标")]
        [PropertyGridEx.PropertyOrder(7)]
        public double XPosition { get; set; }

        [Category("扫描初始位置")]
        [DisplayName("Y轴坐标")]
        [Description("设置Y轴坐标")]
        [PropertyGridEx.PropertyOrder(8)]
        public double YPosition { get; set; }

        [Category("扫描初始位置")]
        [DisplayName("Z轴坐标")]
        [Description("设置Z轴坐标")]
        [PropertyGridEx.PropertyOrder(9)]
        public double ZPosition { get; set; }
        

        public PointCloudInfo()
        {
            PointCloudPath = new OpenFilePath();
            ZMax = 100;
            ZMin = -100;
        }

        public object Clone()
        {
            PointCloudInfo cloneObj = new PointCloudInfo();
            cloneObj.PointCloudPath = this.PointCloudPath;
            cloneObj.XPosition = this.XPosition;
            cloneObj.YPosition = this.YPosition;
            cloneObj.ZPosition = this.ZPosition;
            return cloneObj;
        }
    }
    
    public class PointCloudParam : PropertyGridEx.IPropertyFormEditBase, ICloneable
    {
        public List<PointCloudInfo> PointCloudInfoLst;

        public PointCloudParam()
        {
            PointCloudInfoLst = new List<PointCloudInfo>();
        }

        public void SetValue()
        {
            PointCloudConfig configForm = new PointCloudConfig(this);
            if (configForm.ShowDialog() == DialogResult.OK)
                PointCloudInfoLst = configForm.pointCloudParam.PointCloudInfoLst;
        }

        public object Clone()
        {
            PointCloudParam cloneObj = new PointCloudParam();
            foreach (var item in PointCloudInfoLst)
                cloneObj.PointCloudInfoLst.Add(item.Clone() as PointCloudInfo);
            return cloneObj;
        }

        public override string ToString()
        {
            return "集合";
        }
    }
    
}
