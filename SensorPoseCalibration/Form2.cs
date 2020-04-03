using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonStruct.TypePrim;
using System;
using CommonStruct.Type3D;

namespace SensorPoseCalibration
{
    public partial class Form2 : Form
    {
        LogicControl logicControl;
        List<LCDataShow> pointCloudShow;
        List<Color> pointCloudShowColor;
        public Form2()
        {
            logicControl = new LogicControl();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            treeViewCloud.ExpandAll();
            treeViewCloud.Visible = false;
        }

        private void 加载配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Open File|*.pca";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (logicControl.paramManager.LoadParams(openFile.FileName))
                    UpdateUI();
                else
                    MessageBox.Show("参数加载失败");
            }
        }

        private void 保存配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Save File|*.pca";
            if (saveFile.ShowDialog() == DialogResult.OK)
                if (!logicControl.paramManager.SaveParams(saveFile.FileName))
                    MessageBox.Show("参数保存失败");
        }

        private void 项目管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectConfig projectForm = new ProjectConfig(logicControl.paramManager);
            projectForm.ShowDialog();
            UpdateUI();
        }

        private void UpdateUI()
        {
            comboBoxEx1.Items.Clear();
            List<string> projectLst = logicControl.paramManager.GetAllParamNames();
            foreach (var item in projectLst)
                comboBoxEx1.Items.Add(item);
            if (logicControl.paramManager.GetSelectedParam() == null)
                comboBoxEx1.SelectedItem = null;
            else 
                comboBoxEx1.SelectedItem = logicControl.paramManager.GetSelectedParam().Name;
        }
        

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEx1.SelectedItem == null)
            {
                propertyGridEx1.SelectedObject = null;
                propertyGridEx2.SelectedObject = null;
            }
            else
            {
                logicControl.paramManager.SetSelectedParam(comboBoxEx1.SelectedItem as string);
                PoseCalibrationParam seletedParam = logicControl.paramManager.GetSelectedParam();
                propertyGridEx1.SelectedObject = seletedParam;
                propertyGridEx2.SelectedObject = seletedParam.CalibResult;
            }
        }

        private void 调试窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            调试窗口ToolStripMenuItem.Checked = true;
            点云查看ToolStripMenuItem.Checked = false;
            treeViewCloud.Visible = false;
        }

        private void 点云查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            调试窗口ToolStripMenuItem.Checked = false;
            点云查看ToolStripMenuItem.Checked = true;
            treeViewCloud.Visible = true;
        }
        
        private void buttonCalibPose_Click(object sender, EventArgs e)
        {
            pointCloudShow = new List<LCDataShow>();
            if (comboBoxEx1.SelectedItem != null)
            {
                Dictionary<PointCloudInfo, XDPOINT[,]> srcPointCloudDic;
                Dictionary<PointCloudInfo, XDPOINT[,]> desPointCloudDic;
                string errCode;
                if (!logicControl.CalibrateSensorPose(out srcPointCloudDic,out desPointCloudDic, out errCode))
                {
                    MessageBox.Show(errCode);
                    return;
                }
                foreach (var item in srcPointCloudDic)
                {
                    LCDataShow dataShow = new LCDataShow();
                    dataShow.name = Guid.NewGuid().ToString();
                    dataShow.dataType = DataShowType.PointArray;
                    dataShow.data = item.Value;
                    dataShow.color = Color.White;
                    dataShow.isShow = true;
                    pointCloudShow.Add(dataShow);
                }
                foreach (var item in desPointCloudDic)
                {
                    LCDataShow dataShow = new LCDataShow();
                    dataShow.name = Guid.NewGuid().ToString();
                    dataShow.dataType = DataShowType.PointArray;
                    dataShow.data = item.Value;
                    dataShow.color = Color.LimeGreen;
                    dataShow.isShow = true;
                    pointCloudShow.Add(dataShow);
                }
                map3D1.ClearAll();
                foreach (var item in pointCloudShow)
                    map3D1.UpdateDataElem(item.name, item);
                map3D1.UpdateData();
            }
        }
        
        private void buttonSavePose_Click(object sender, EventArgs e)
        {
            if (!logicControl.SaveResultPose())
                return;
        }
    }
}
