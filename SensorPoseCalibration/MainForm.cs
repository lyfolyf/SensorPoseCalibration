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
using System.Threading;

namespace SensorPoseCalibration
{
    public partial class MainForm : Form
    {
        LogicControl logicControl;
        Dictionary<LCDataShow, PointCloudShowParam> srcPointCloudInfo, desPointCloudInfo;
        private string strConfigPath;
        public bool isLoadingDone;

        public MainForm()
        {
            logicControl = new LogicControl();
            LogicControl.OnPointCloudListChanged += OnPointCloudListChanged;
            LogicControl.OnPointCloudColorChanged += OnPointCloudColorChanged;
            srcPointCloudInfo = new Dictionary<LCDataShow, PointCloudShowParam>();
            desPointCloudInfo = new Dictionary<LCDataShow, PointCloudShowParam>();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelEx4.Visible = false;
        }

        private void OnPointCloudListChanged(object sender, EventArgs e)
        {
            treeViewCloud.Nodes.Clear();
            srcPointCloudInfo.Clear();
            desPointCloudInfo.Clear();
            PoseCalibrationParam seletedParam = logicControl.paramManager.GetSelectedParam();
            if (seletedParam != null)
            {
                List<PointCloudInfo> pointCloudList = seletedParam.PointCloudParams.PointCloudInfoLst;
                if (pointCloudList.Count > 0)
                {
                    treeViewCloud.Nodes.Add("校正前");
                    treeViewCloud.Nodes.Add("校正后");
                    
                    for (int i = 0; i < pointCloudList.Count; i++)
                    {
                        treeViewCloud.Nodes[0].Nodes.Add("点云" + i).ImageIndex = 0;
                        treeViewCloud.Nodes[1].Nodes.Add("点云" + i).ImageIndex = 0;

                        LCDataShow srcDataShow = new LCDataShow();
                        srcDataShow.name = Guid.NewGuid().ToString();
                        srcDataShow.dataType = DataShowType.PointArray;
                        srcDataShow.color = Color.White;
                        srcDataShow.isShow = true;
                        srcPointCloudInfo[srcDataShow] = new PointCloudShowParam(Color.White);

                        LCDataShow desDataShow = new LCDataShow();
                        desDataShow.name = Guid.NewGuid().ToString();
                        desDataShow.dataType = DataShowType.PointArray;
                        desDataShow.color = Color.White;
                        desDataShow.isShow = true;
                        desPointCloudInfo[desDataShow] = new PointCloudShowParam(Color.White);

                    }
                    treeViewCloud.ExpandAll();
                    UpdateMap3D();
                }
            }
            treeViewCloud.Refresh();
        }

        private void OnPointCloudColorChanged(object sender, EventArgs e)
        {
            UpdateMap3D();
        }

        private void 加载配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Open File|*.pca";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                strConfigPath = openFile.FileName;
                bool loadResult = logicControl.paramManager.LoadParams(strConfigPath);
                string logInfo = loadResult ? "参数加载完成" : "参数加载失败";
                UpdateLogInfo(logInfo);
                if(loadResult)
                {
                    UpdateComboItems();
                    OnPointCloudListChanged(new object(), new EventArgs());
                }
            }
        }

        private void 保存配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(strConfigPath))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Save File|*.pca";
                if (saveFile.ShowDialog() != DialogResult.OK)
                    return;
                strConfigPath = saveFile.FileName;
            }
            bool saveResult = logicControl.paramManager.SaveParams(strConfigPath);
            string logInfo = saveResult ? "参数保存完成" : "参数保存失败";
            UpdateLogInfo(logInfo);
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Save File|*.pca";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                bool saveResult = logicControl.paramManager.SaveParams(saveFile.FileName);
                string logInfo = saveResult ? "参数另存完成" : "参数另存失败";
                UpdateLogInfo(logInfo);
            }
        }

        private void 计算姿态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalibratePose();
        }

        private void 保存结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveResultPose();
        }

        private void 系统日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            系统日志ToolStripMenuItem.Checked = !系统日志ToolStripMenuItem.Checked;
            panelEx4.Visible = 系统日志ToolStripMenuItem.Checked;
        }

        private void 项目管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectConfig projectForm = new ProjectConfig(logicControl.paramManager);
            projectForm.ShowDialog();
            UpdateComboItems();
        }

        private void UpdateComboItems()
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
                seletedParam.SetPropertyGrid(propertyGridEx1);
                propertyGridEx2.SelectedObject = seletedParam.CalibResult;
            }
        }
        
        private void buttonCalibPose_Click(object sender, EventArgs e)
        {
            CalibratePose();
        }

        private void CalibratePose()
        {
            if (comboBoxEx1.SelectedItem != null)
            {
                Dictionary<PointCloudInfo, XDPOINT[,]> srcPointCloudDic;
                Dictionary<PointCloudInfo, XDPOINT[,]> desPointCloudDic;
                string errCode;
                UpdateLogInfo("姿态计算开始");
                Thread _thread = new Thread(() => { Loading loadingForm = new Loading(this); loadingForm.ShowDialog(); });
                _thread.IsBackground = true;
                _thread.Start();
                bool calibResult = logicControl.CalibrateSensorPose(out srcPointCloudDic, out desPointCloudDic, out errCode);
                isLoadingDone = true;
                string logInfo = calibResult ? "姿态计算完成" : "姿态计算失败";
                UpdateLogInfo(logInfo);
                if (calibResult)
                {
                    PoseCalibrationParam seletedParam = logicControl.paramManager.GetSelectedParam();
                    propertyGridEx2.SelectedObject = seletedParam.CalibResult;
                    labelEx2.BackColor = seletedParam.CalibResult.FinalCost > seletedParam.FinalCostThreshold ? Color.Red : Color.FromArgb(210, 210, 255);
                    for (int i = 0; i < srcPointCloudDic.Count; i++)
                    {
                        srcPointCloudInfo.ElementAt(i).Key.data = srcPointCloudDic.ElementAt(i).Value;
                        desPointCloudInfo.ElementAt(i).Key.data = desPointCloudDic.ElementAt(i).Value;
                    }
                    UpdateMap3D();
                }

            }
        }

        
        private void buttonSavePose_Click(object sender, EventArgs e)
        {
            SaveResultPose();
        }

        private void SaveResultPose()
        {
            bool saveResult = logicControl.SaveResultPose();
            string logInfo = saveResult ? "姿态保存完成" : "姿态保存失败";
            UpdateLogInfo(logInfo);
        }
        
        private void UpdateMap3D()
        {
            map3D1.ClearAll();
            Dictionary<LCDataShow, PointCloudShowParam> allDataShowDic = srcPointCloudInfo.Concat(desPointCloudInfo).ToDictionary(p => p.Key, p => p.Value);
            foreach (var item in allDataShowDic)
            {
                item.Key.color = item.Value.DisplayColor;
                map3D1.UpdateDataElem(item.Key.name, item.Key);
            }
            map3D1.UpdateData();
        }

        private void treeViewCloud_OnNodeImageClick(object sender, int index)
        {
            TreeNode node = (TreeNode)sender;
            if(node.Parent != null)
            {
                if (node.Parent == treeViewCloud.Nodes[0])
                {
                    srcPointCloudInfo.ElementAt(node.Index).Key.isShow = !srcPointCloudInfo.ElementAt(node.Index).Key.isShow;
                    node.ImageIndex = srcPointCloudInfo.ElementAt(node.Index).Key.isShow ? 0 : 1;
                } 
                else
                {
                    desPointCloudInfo.ElementAt(node.Index).Key.isShow = !desPointCloudInfo.ElementAt(node.Index).Key.isShow;
                    node.ImageIndex = desPointCloudInfo.ElementAt(node.Index).Key.isShow ? 0 : 1;
                }
                treeViewCloud.Refresh();
                UpdateMap3D();
            }
            else
                propertyGridEx3.SelectedObject = null;
        }
        
        private void treeViewCloud_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                PointCloudShowParam pointCloudParam;
                if (e.Node.Parent == treeViewCloud.Nodes[0])
                    pointCloudParam = srcPointCloudInfo.ElementAt(e.Node.Index).Value;
                else
                    pointCloudParam = desPointCloudInfo.ElementAt(e.Node.Index).Value;
                propertyGridEx3.SelectedObject = pointCloudParam;
            }
            else
                propertyGridEx3.SelectedObject = null;
        }


        private void UpdateLogInfo(string strMsg)
        {
            textBoxEx1.MultiLinesAdd(DateTime.Now.ToString() + "    " + strMsg);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logicControl.AlgoDispose();
        }
        
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == ToolStripMenuItemLeft)
                map3D1.ViewMode = ViewMode.Left;
            else if(item == ToolStripMenuItemRight)
                map3D1.ViewMode = ViewMode.Right;
            else if (item == ToolStripMenuItemFront)
                map3D1.ViewMode = ViewMode.Front;
            else if (item == ToolStripMenuItemBack)
                map3D1.ViewMode = ViewMode.Back;
            else if (item == ToolStripMenuItemUp)
                map3D1.ViewMode = ViewMode.Top;
            else if (item == ToolStripMenuItemDown)
                map3D1.ViewMode = ViewMode.Bottom;
            UpdateMap3D();
        }
        

    }
}
