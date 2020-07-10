using CommonStruct.Type3D;
using ComponentLib;
using ComponentLib.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static ComponentLib.PropertyGridEx;

namespace SensorPoseCalibration
{
    public class ParamManager
    {
        static Type[] types = new Type[] { typeof(PoseCalibrationParam), typeof(PoseCalibrationResult),typeof(PointCloudParam), typeof(PointCloudInfo),
            typeof(SaveFilePath), typeof(OpenFilePath), typeof(MoveAxis),typeof(ScanDir),typeof(XPosDir),typeof(YPosDir),typeof(ZPosDir)};
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
            return true; ;
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
            if (_poseParamDic.Keys.Contains(name))
            {
                _poseParamDic = _poseParamDic.ToDictionary(p => p.Key, p => new PoseCalibrationParam(p.Value) { IsConfig = (p.Key == name) });
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
        private PropertyGridEx _propertyGrid;
        private bool _isSensorMove;

        [Category("点云")]
        [Browsable(true)]
        [DisplayName("点云数据")]
        [Description("设置点云参数")]
        [PropertyOrder(0)]
        public PointCloudParam PointCloudParams { get; set; }

        [Category("设备设置")]
        [Browsable(true)]
        [DisplayName("传感器移动")]
        [Description("设置传感器是否可移动")]
        [PropertyOrder(1)]
        public bool IsSensorMove
        {
            get
            {
                return _isSensorMove;
            }
            set
            {
                _isSensorMove = value;
                if(_propertyGrid != null)
                {
                    _propertyGrid.SetPropertyVisibility("IsSensorMove", "MoveAxis", _isSensorMove);
                    _propertyGrid.Refresh();
                }
            }
        }

        [Category("设备设置")]
        [Browsable(true)]
        [DisplayName("移动轴")]
        [Description("设置传感器移动轴")]
        [PropertyOrder(2)]
        public MoveAxis MoveAxis { get; set; }

        [Category("设备设置")]
        [Browsable(true)]
        [DisplayName("扫描方向")]
        [Description("设置扫描方向")]
        [PropertyOrder(3)]
        public ScanDir ScanDir { get; set; }

        [Category("设备设置")]
        [Browsable(true)]
        [DisplayName("线宽正向")]
        [Description("设置线宽方向是否为正向")]
        [PropertyOrder(4)]
        public bool IsPositiveDir { get; set; }

        [Category("设备设置")]
        [Browsable(true)]
        [DisplayName("X轴正向")]
        [Description("设置X轴正向")]
        [PropertyOrder(5)]
        public XPosDir XPosDir { get; set; }

        [Category("设备设置")]
        [Browsable(true)]
        [DisplayName("Y轴正向")]
        [Description("设置Y轴正向")]
        [PropertyOrder(6)]
        public YPosDir YPosDir { get; set; }

        [Category("设备设置")]
        [Browsable(true)]
        [DisplayName("Z轴正向")]
        [Description("设置Z轴正向")]
        [PropertyOrder(7)]
        public ZPosDir ZPosDir { get; set; }

        [Category("初始值")]
        [Browsable(true)]
        [DisplayName("X夹角")]
        [Description("设置X夹角")]
        [PropertyOrder(1)]
        public double InitAngleX { get; set; }

        [Category("初始值")]
        [Browsable(true)]
        [DisplayName("Y夹角")]
        [Description("设置Y夹角")]
        [PropertyOrder(2)]
        public double InitAngleY { get; set; }

        [Category("初始值")]
        [Browsable(true)]
        [DisplayName("Z夹角")]
        [Description("设置Z夹角")]
        [PropertyOrder(3)]
        public double InitAngleZ { get; set; }

        [Category("迭代参数")]
        [Browsable(true)]
        [DisplayName("次数")]
        [Description("设置计算迭代次数")]
        [Range(50,1000)]
        [PropertyOrder(4)]
        public int IterateNums { get; set; }

        [Category("残差")]
        [Browsable(true)]
        [DisplayName("残差阈值")]
        [Description("设置残差阈值")]
        [PropertyOrder(5)]
        public double FinalCostThreshold { get; set; }

        [Browsable(false)]
        public string Name { get; set; }

        [Browsable(false)]
        public bool IsConfig { get; set; }

        [Browsable(false)]
        public PoseCalibrationResult CalibResult { get; set; }
        public PoseCalibrationParam()
        {
            PointCloudParams = new PointCloudParam();
            IsSensorMove = true;
            MoveAxis = new MoveAxis();
            ScanDir = new ScanDir();
            IsPositiveDir = true;
            XPosDir = new XPosDir();
            YPosDir = new YPosDir();
            ZPosDir = new ZPosDir();
            CalibResult = new PoseCalibrationResult();
            IterateNums = 100;
            FinalCostThreshold = 0.001;
        }

        public PoseCalibrationParam(PoseCalibrationParam param)
        {
            this._propertyGrid = param._propertyGrid;
            this.PointCloudParams = param.PointCloudParams;
            this.IsSensorMove = param.IsSensorMove;
            this.MoveAxis = param.MoveAxis;
            this.ScanDir = param.ScanDir;
            this.IsPositiveDir = param.IsPositiveDir;
            this.XPosDir = param.XPosDir;
            this.YPosDir = param.YPosDir;
            this.ZPosDir = param.ZPosDir;
            this.InitAngleX = param.InitAngleX;
            this.InitAngleY = param.InitAngleY;
            this.InitAngleZ = param.InitAngleZ;
            this.IterateNums = param.IterateNums;
            this.FinalCostThreshold = param.FinalCostThreshold;
            this.CalibResult = param.CalibResult;
            this.Name = param.Name;
            this.IsConfig = param.IsConfig;
        }

        public void SetPropertyGrid(PropertyGridEx grid)
        {
            _propertyGrid = grid;
        }
    }

    public class PoseCalibrationResult
    {
        [Category("保存姿态")]
        [DisplayName("路径")]
        [Description("设置保存路径")]
        [Browsable(false)]
        [PropertyOrder(0)]
        public SaveFilePath SavePath { get; set; }

        [Category("输出")]
        [DisplayName("残差")]
        [Description("输出残差结果")]
        [ReadOnly(true)]
        [PropertyOrder(1)]
        public double FinalCost { get; set; }

        [Category("输出")]
        [DisplayName("X夹角")]
        [Description("输出X夹角结果")]
        [ReadOnly(true)]
        [PropertyOrder(2)]
        public double ResultAngleX { get; set; }

        [Category("输出")]
        [DisplayName("Y夹角")]
        [Description("输出Y夹角结果")]
        [ReadOnly(true)]
        [PropertyOrder(3)]
        public double ResultAngleY { get; set; }

        [Category("输出")]
        [DisplayName("Z夹角")]
        [Description("输出Z夹角结果")]
        [ReadOnly(true)]
        [PropertyOrder(4)]
        public double ResultAngleZ { get; set; }

        [Category("详细信息")]
        [DisplayName("球心/半径")]
        [Description("查看球心/半径")]
        [PropertyOrder(5)]
        [XmlIgnore]
        public ResultCenterRadius CenterRadius { get; set; }

        public PoseCalibrationResult()
        {
            SavePath = new SaveFilePath();
            CenterRadius = new ResultCenterRadius();
        }

    }

    public class OpenFilePath : IPropertyFormEditBase
    {
        public string pathName;
        public object SetValue()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PointCloud File|*.txt;*.csv";
            if (openFile.ShowDialog() == DialogResult.OK)
                pathName = openFile.FileName;
            return this;
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

    public class SaveFilePath : IPropertyFormEditBase
    {
        public string pathName;
        public object SetValue()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Save File|*.txt;*.csv";
            if (saveFile.ShowDialog() == DialogResult.OK)
                pathName = saveFile.FileName;
            return this;
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
        [PropertyOrder(0)]
        public OpenFilePath PointCloudPath { get; set; }

        [Category("点云")]
        [DisplayName("阵列数据")]
        [Description("设置点云是否为阵列数据")]
        [PropertyOrder(1)]
        public bool IsPointArray { get; set; }

        [Category("点云")]
        [DisplayName("光强")]
        [Description("设置点云数据是否包含光强")]
        [PropertyOrder(2)]
        public bool IsIncludeIntensity { get; set; }

        [Category("点云")]
        [DisplayName("Z最大值")]
        [Description("设置Z最大值")]
        [PropertyOrder(3)]
        public double ZMax { get; set; }

        [Category("点云")]
        [DisplayName("Z最小值")]
        [Description("设置Z最小值")]
        [PropertyOrder(4)]
        public double ZMin { get; set; }

        [Category("扫描初始位置")]
        [DisplayName("X轴坐标")]
        [Description("设置X轴坐标")]
        [PropertyOrder(7)]
        public double XPosition { get; set; }

        [Category("扫描初始位置")]
        [DisplayName("Y轴坐标")]
        [Description("设置Y轴坐标")]
        [PropertyOrder(8)]
        public double YPosition { get; set; }

        [Category("扫描初始位置")]
        [DisplayName("Z轴坐标")]
        [Description("设置Z轴坐标")]
        [PropertyOrder(9)]
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

        public object SetValue()
        {
            PointCloudConfig configForm = new PointCloudConfig(this);
            if (configForm.ShowDialog() == DialogResult.OK)
            {
                PointCloudInfoLst = configForm.pointCloudParam.PointCloudInfoLst;
                NotifyPointCloudListChanged();
            }
            return this;
        }

        private void NotifyPointCloudListChanged()
        {
            if (LogicControl.OnPointCloudListChanged != null)
                LogicControl.OnPointCloudListChanged.Invoke(new object(), new EventArgs());
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

    public class ResultCenterRadius : PropertyGridEx.IPropertyFormEditBase
    {
        public List<Tuple<XDPOINT,double>> CenterRadiusLst;

        public ResultCenterRadius()
        {
            CenterRadiusLst = new List<Tuple<XDPOINT, double>>();
        }

        public object SetValue()
        {
            ResultCenterRadiusShow showForm = new ResultCenterRadiusShow(this);
            showForm.ShowDialog();
            return this;
        }

        public override string ToString()
        {
            return "集合";
        }
    }

    public enum MoveAxisEnum
    {
        X轴,
        Y轴,
        Z轴
    }

    public class MoveAxis : PropertyGridEx.IPropertyComboEditBase
    {
        private string[] StringList;
        public string[] SelectedList;

        [XmlIgnore]
        public List<int> SelectedItems
        {
            get
            {
                List<int> selectedItems = new List<int>();
                foreach (var item in SelectedList)
                    selectedItems.Add(StringList.ToList().FindIndex(p=>p==item));
                return selectedItems;
            }
        }

        public bool IsMultiSelect { get; set; }

        public MoveAxis()
        {
            IsMultiSelect = true;
            StringList = typeof(MoveAxisEnum).GetEnumNames();
            SelectedList = new string[] { typeof(MoveAxisEnum).GetEnumName(MoveAxisEnum.Z轴) };
        }
        
        public void GetEditList(out List<string> strLst, out List<string> selectedLst)
        {
            strLst = StringList.ToList();
            selectedLst = SelectedList.ToList();
        }

        public PropertyGridEx.IPropertyComboEditBase SetValue(List<string> selectedLst)
        {
            SelectedList = selectedLst.ToArray();
            return this;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach(var item in SelectedList)
            {
                str += item;
                if (item != SelectedList[SelectedList.Length - 1])
                    str += ",";
            }
            return str;
        }

    }

    public enum ScanDirEnum
    {
        沿X轴扫描,
        沿Y轴扫描
    }

    public class ScanDir : PropertyGridEx.IPropertyComboEditBase
    {
        private string[] StringList;
        public string[] SelectedList;

        [XmlIgnore]
        public int SelectedItem
        {
            get
            {
                return StringList.ToList().FindIndex(p => p == SelectedList[0]);
            }
        }

        public bool IsMultiSelect { get; set; }

        public ScanDir()
        {
            IsMultiSelect = false;
            StringList = typeof(ScanDirEnum).GetEnumNames();
            SelectedList = new string[] { typeof(ScanDirEnum).GetEnumName(ScanDirEnum.沿X轴扫描) };
        }

        public void GetEditList(out List<string> strLst, out List<string> selectedLst)
        {
            strLst = StringList.ToList();
            selectedLst = SelectedList.ToList();
        }

        public PropertyGridEx.IPropertyComboEditBase SetValue(List<string> selectedLst)
        {
            SelectedList = selectedLst.ToArray();
            return this;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (var item in SelectedList)
            {
                str += item;
                if (item != SelectedList[SelectedList.Length - 1])
                    str += ",";
            }
            return str;
        }

    }

    public enum XPosDirEnum
    {
        向左,
        向右
    }

    public class XPosDir : PropertyGridEx.IPropertyComboEditBase
    {
        private string[] StringList;
        public string[] SelectedList;

        [XmlIgnore]
        public bool SelectedItem
        {
            get
            {
                return SelectedList[0] == StringList[1];
            }
        }

        public bool IsMultiSelect { get; set; }

        public XPosDir()
        {
            IsMultiSelect = false;
            StringList = typeof(XPosDirEnum).GetEnumNames();
            SelectedList = new string[] { typeof(XPosDirEnum).GetEnumName(XPosDirEnum.向右) };
        }

        public void GetEditList(out List<string> strLst, out List<string> selectedLst)
        {
            strLst = StringList.ToList();
            selectedLst = SelectedList.ToList();
        }

        public PropertyGridEx.IPropertyComboEditBase SetValue(List<string> selectedLst)
        {
            SelectedList = selectedLst.ToArray();
            return this;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (var item in SelectedList)
            {
                str += item;
                if (item != SelectedList[SelectedList.Length - 1])
                    str += ",";
            }
            return str;
        }

    }

    public enum YPosDirEnum
    {
        向里,
        向外
    }

    public class YPosDir : PropertyGridEx.IPropertyComboEditBase
    {
        private string[] StringList;
        public string[] SelectedList;

        [XmlIgnore]
        public bool SelectedItem
        {
            get
            {
                return SelectedList[0] == StringList[0];
            }
        }

        public bool IsMultiSelect { get; set; }

        public YPosDir()
        {
            IsMultiSelect = false;
            StringList = typeof(YPosDirEnum).GetEnumNames();
            SelectedList = new string[] { typeof(YPosDirEnum).GetEnumName(YPosDirEnum.向外) };
        }

        public void GetEditList(out List<string> strLst, out List<string> selectedLst)
        {
            strLst = StringList.ToList();
            selectedLst = SelectedList.ToList();
        }

        public PropertyGridEx.IPropertyComboEditBase SetValue(List<string> selectedLst)
        {
            SelectedList = selectedLst.ToArray();
            return this;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (var item in SelectedList)
            {
                str += item;
                if (item != SelectedList[SelectedList.Length - 1])
                    str += ",";
            }
            return str;
        }

    }

    public enum ZPosDirEnum
    {
        向上,
        向下
    }

    public class ZPosDir : PropertyGridEx.IPropertyComboEditBase
    {
        private string[] StringList;
        public string[] SelectedList;

        [XmlIgnore]
        public bool SelectedItem
        {
            get
            {
                return SelectedList[0] == StringList[0];
            }
        }

        public bool IsMultiSelect { get; set; }

        public ZPosDir()
        {
            IsMultiSelect = false;
            StringList = typeof(ZPosDirEnum).GetEnumNames();
            SelectedList = new string[] { typeof(ZPosDirEnum).GetEnumName(ZPosDirEnum.向上) };
        }

        public void GetEditList(out List<string> strLst, out List<string> selectedLst)
        {
            strLst = StringList.ToList();
            selectedLst = SelectedList.ToList();
        }

        public PropertyGridEx.IPropertyComboEditBase SetValue(List<string> selectedLst)
        {
            SelectedList = selectedLst.ToArray();
            return this;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (var item in SelectedList)
            {
                str += item;
                if (item != SelectedList[SelectedList.Length - 1])
                    str += ",";
            }
            return str;
        }

    }

    public class PointCloudShowParam
    {
        private Color _displayColor;

        [Category("点云显示")]
        [DisplayName("颜色")]
        [Description("设置点云显示颜色")]
        [PropertyOrder(0)]
        public Color DisplayColor
        {
            get
            {
                return _displayColor;
            }
            set
            {
                _displayColor = value;
                if (LogicControl.OnPointCloudColorChanged != null)
                    LogicControl.OnPointCloudColorChanged.Invoke(new object(),new EventArgs());
            }
        }
        
        public PointCloudShowParam(Color color)
        {
            _displayColor = color;
        }
    }
    
}
