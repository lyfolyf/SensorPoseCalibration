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
        Dictionary<string, Dictionary<LCDataShow, PointCloudShowParam>> srcPointCloudInfoDic, desPointCloudInfoDic;
        private string strConfigPath;
        private PoseCalibrationParam selectedParam;
        public static bool isLoadingDone;
        private bool calibResult;
        private string errCode;
        Dictionary<PointCloudInfo, XDPOINT[,]> desPointCloudDic;

        public MainForm()
        {
            logicControl = new LogicControl();
            LogicControl.OnPointCloudListChanged += OnPointCloudListChanged;
            LogicControl.OnPointCloudColorChanged += OnPointCloudColorChanged;
            srcPointCloudInfoDic = new Dictionary<string, Dictionary<LCDataShow, PointCloudShowParam>>();
            desPointCloudInfoDic = new Dictionary<string, Dictionary<LCDataShow, PointCloudShowParam>>();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void OnPointCloudListChanged(object sender, EventArgs e)
        {
            treeViewCloud.Nodes.Clear();
            if (selectedParam != null)
            {
                if (!srcPointCloudInfoDic.Keys.Contains(selectedParam.Name))
                    srcPointCloudInfoDic[selectedParam.Name] = new Dictionary<LCDataShow, PointCloudShowParam>();
                srcPointCloudInfoDic[selectedParam.Name].Clear();
                if (!desPointCloudInfoDic.Keys.Contains(selectedParam.Name))
                    desPointCloudInfoDic[selectedParam.Name] = new Dictionary<LCDataShow, PointCloudShowParam>();
                desPointCloudInfoDic[selectedParam.Name].Clear();
                Dictionary<PointCloudInfo, XDPOINT[,]> srcPointCloudDic;
                string errCode;
                if (!logicControl.GetSourcePointCloud(out srcPointCloudDic, out errCode))
                    MessageBox.Show(errCode);
                else
                {
                    List<PointCloudInfo> pointCloudList = selectedParam.PointCloudParams.PointCloudInfoLst;
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
                            srcDataShow.data = srcPointCloudDic.ElementAt(i).Value;
                            srcDataShow.color = Color.White;
                            srcDataShow.isShow = true;
                            srcPointCloudInfoDic[selectedParam.Name][srcDataShow] = new PointCloudShowParam(Color.FromKnownColor((KnownColor)((10 * i + 3) % 175)));

                            LCDataShow desDataShow = new LCDataShow();
                            desDataShow.name = Guid.NewGuid().ToString();
                            desDataShow.dataType = DataShowType.PointArray;
                            desDataShow.color = Color.White;
                            desDataShow.isShow = true;
                            desPointCloudInfoDic[selectedParam.Name][desDataShow] = new PointCloudShowParam(Color.FromKnownColor((KnownColor)((20 * i + 3) % 175)));

                        }
                        treeViewCloud.ExpandAll();
                    }
                }
            }
            UpdateMap3D();
            treeViewCloud.Refresh();
        }

        private void UpdateSelectedItem()
        {
            treeViewCloud.Nodes.Clear();
            propertyGridEx3.SelectedObject = null;
            if (selectedParam != null)
            {
                if(srcPointCloudInfoDic.Keys.Contains(selectedParam.Name) && desPointCloudInfoDic.Keys.Contains(selectedParam.Name))
                {
                    List<PointCloudInfo> pointCloudList = selectedParam.PointCloudParams.PointCloudInfoLst;
                    if (pointCloudList.Count > 0)
                    {
                        treeViewCloud.Nodes.Add("校正前");
                        treeViewCloud.Nodes.Add("校正后");
                        for (int i = 0; i < pointCloudList.Count; i++)
                        {
                            treeViewCloud.Nodes[0].Nodes.Add("点云" + i).ImageIndex = srcPointCloudInfoDic[selectedParam.Name].ElementAt(i).Key.isShow ? 0 : 1;
                            treeViewCloud.Nodes[1].Nodes.Add("点云" + i).ImageIndex = desPointCloudInfoDic[selectedParam.Name].ElementAt(i).Key.isShow ? 0 : 1;
                        }
                        treeViewCloud.ExpandAll();
                    }
                }
            }
            UpdateMap3D();
            treeViewCloud.Refresh();
        }

        private void OnPointCloudColorChanged(object sender, EventArgs e)
        {
            UpdateMap3D();
        }

        private void 加载配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Open File|*.pca";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                strConfigPath = openFile.FileName;
                bool loadResult = logicControl.paramManager.LoadParams(strConfigPath);
                string logInfo = loadResult ? "参数加载完成" : "参数加载失败";
                UpdateLogInfo(logInfo);
                if (loadResult)
                {
                    UpdateComboItems();
                    OnPointCloudListChanged(new object(), new EventArgs());
                }
            }
        }

        private void 保存配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void SaveConfig()
        {
            if (string.IsNullOrEmpty(strConfigPath))
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
            SaveAsConfig();
        }

        private void SaveAsConfig()
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
            if(selectedParam == null)
            {
                if (projectLst.Count > 0)
                    comboBoxEx1.SelectedItem = projectLst[0];
                else
                    comboBoxEx1.SelectedItem = null;
            }
            else
            {
                if (!projectLst.Contains(selectedParam.Name))
                    comboBoxEx1.SelectedItem = projectLst.Count > 0 ? projectLst[0] : null;
                else
                    comboBoxEx1.SelectedItem = selectedParam.Name;
            }
        }
        

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEx1.SelectedItem == null)
            {
                selectedParam = null;
                propertyGridEx1.SelectedObject = selectedParam;
                propertyGridEx2.SelectedObject = selectedParam;
            }
            else
            {
                logicControl.paramManager.SetSelectedParam(comboBoxEx1.SelectedItem as string);
                selectedParam = logicControl.paramManager.GetSelectedParam();
                propertyGridEx1.SelectedObject = selectedParam;
                selectedParam.SetPropertyGrid(propertyGridEx1);
                propertyGridEx2.SelectedObject = selectedParam.CalibResult;
            }
            UpdateSelectedItem();
        }
        
        private void buttonCalibPose_Click(object sender, EventArgs e)
        {
            CalibratePose();
        }
        
        private void CalibratePose()
        {
            if (selectedParam != null)
            {
                UpdateLogInfo("姿态计算开始");
                isLoadingDone = false;
                Thread _thread = new Thread(() =>
                {
                    calibResult = logicControl.CalibrateSensorPose(out desPointCloudDic, out errCode);
                    isLoadingDone = true;
                });
                _thread.IsBackground = true;
                _thread.Start();
                Loading loadingForm = new Loading(this);
                loadingForm.ShowDialog();
                string logInfo = calibResult ? "姿态计算完成" : errCode;
                UpdateLogInfo(logInfo);
                if (calibResult)
                {
                    propertyGridEx2.SelectedObject = selectedParam.CalibResult;
                    labelEx2.BackColor = selectedParam.CalibResult.FinalCost > selectedParam.FinalCostThreshold ? Color.Red : Color.FromArgb(210, 210, 255);
                    for (int i = 0; i < desPointCloudDic.Count; i++)
                    {
                        treeViewCloud.Nodes[0].Nodes[i].ImageIndex = 1;
                        srcPointCloudInfoDic[selectedParam.Name].ElementAt(i).Key.isShow = false;
                        desPointCloudInfoDic[selectedParam.Name].ElementAt(i).Key.data = desPointCloudDic.ElementAt(i).Value;
                    }
                    treeViewCloud.Refresh();
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
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Save File|*.txt;*.csv";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string errCode = string.Empty;
                bool saveResult = logicControl.SaveResultPose(saveFile.FileName,out errCode);
                string logInfo = saveResult ? "姿态保存完成" : errCode;
                UpdateLogInfo(logInfo);
            }
        }
        
        private void UpdateMap3D()
        {
            map3D1.ClearAll();
            if(selectedParam != null)
            {
                if(srcPointCloudInfoDic.Keys.Contains(selectedParam.Name) && desPointCloudInfoDic.Keys.Contains(selectedParam.Name))
                {
                    Dictionary<LCDataShow, PointCloudShowParam> allDataShowDic = srcPointCloudInfoDic[selectedParam.Name].Concat(desPointCloudInfoDic[selectedParam.Name]).ToDictionary(p => p.Key, p => p.Value);
                    foreach (var item in allDataShowDic)
                    {
                        item.Key.color = item.Value.DisplayColor;
                        map3D1.UpdateDataElem(item.Key.name, item.Key);
                    }
                }
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
                    srcPointCloudInfoDic[selectedParam.Name].ElementAt(node.Index).Key.isShow = !srcPointCloudInfoDic[selectedParam.Name].ElementAt(node.Index).Key.isShow;
                    node.ImageIndex = srcPointCloudInfoDic[selectedParam.Name].ElementAt(node.Index).Key.isShow ? 0 : 1;
                } 
                else
                {
                    desPointCloudInfoDic[selectedParam.Name].ElementAt(node.Index).Key.isShow = !desPointCloudInfoDic[selectedParam.Name].ElementAt(node.Index).Key.isShow;
                    node.ImageIndex = desPointCloudInfoDic[selectedParam.Name].ElementAt(node.Index).Key.isShow ? 0 : 1;
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
                    pointCloudParam = srcPointCloudInfoDic[selectedParam.Name].ElementAt(e.Node.Index).Value;
                else
                    pointCloudParam = desPointCloudInfoDic[selectedParam.Name].ElementAt(e.Node.Index).Value;
                propertyGridEx3.SelectedObject = pointCloudParam;
            }
            else
                propertyGridEx3.SelectedObject = null;
        }


        private void UpdateLogInfo(string strMsg)
        {
            int index = dataGridViewEx1.Rows.Add();
            dataGridViewEx1.Rows[index].Cells[0].Value = DateTime.Now.ToString();
            dataGridViewEx1.Rows[index].Cells[1].Value = strMsg;
            if (index > 50)
                dataGridViewEx1.Rows.RemoveAt(0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logicControl.AlgoDispose();
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            ComponentLib.ButtonEx clickBtn = (ComponentLib.ButtonEx)sender;
            if (clickBtn == btn_load_config)
                LoadConfig();
            else if (clickBtn == btn_save_config)
                SaveConfig();
            else if (clickBtn == btn_saveas_config)
                SaveAsConfig();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            ComponentLib.ButtonEx clickBtn = (ComponentLib.ButtonEx)sender;
            if (clickBtn == btn_Left_view)
                map3D1.ViewMode = ViewMode.Left;
            else if (clickBtn == btn_Right_view)
                map3D1.ViewMode = ViewMode.Right;
            else if (clickBtn == btn_Front_view)
                map3D1.ViewMode = ViewMode.Front;
            else if (clickBtn == btn_Back_view)
                map3D1.ViewMode = ViewMode.Back;
            else if (clickBtn == btn_Up_view)
                map3D1.ViewMode = ViewMode.Top;
            else if (clickBtn == btn_Down_view)
                map3D1.ViewMode = ViewMode.Bottom;
            UpdateMap3D();
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
            else if (item == ToolStripMenuItemTop)
                map3D1.ViewMode = ViewMode.Top;
            else if (item == ToolStripMenuItemBottom)
                map3D1.ViewMode = ViewMode.Bottom;
            UpdateMap3D();
        }
        
    }
}
