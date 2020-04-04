using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorPoseCalibration
{
    public partial class PointCloudConfig : Form
    {
        public PointCloudParam pointCloudParam;
        public PointCloudConfig(PointCloudParam param)
        {
            pointCloudParam = param.Clone() as PointCloudParam;
            InitializeComponent();
        }

        private void PointCloudConfig_Load(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            treeViewPointLst.Nodes.Clear();
            for (int i = 0; i < pointCloudParam.PointCloudInfoLst.Count; i++)
                treeViewPointLst.Nodes.Add("点云" + i);
            if (pointCloudParam.PointCloudInfoLst.Count > 0)
                treeViewPointLst.SelectedNode = treeViewPointLst.Nodes[0];
            else
                treeViewPointLst.SelectedNode = null;
            UpdatePropertyGrid();
            treeViewPointLst.Refresh();
        }
        
        private void UpdatePropertyGrid()
        {
            if (treeViewPointLst.SelectedNode == null)
                propertyGridEdit.SelectedObject = null;
            else
                propertyGridEdit.SelectedObject = pointCloudParam.PointCloudInfoLst[treeViewPointLst.SelectedNode.Index];
        }

        private void treeViewPointLst_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            UpdatePropertyGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            pointCloudParam.PointCloudInfoLst.Add(new PointCloudInfo());
            treeViewPointLst.Nodes.Add("点云" + (pointCloudParam.PointCloudInfoLst.Count - 1));
            treeViewPointLst.SelectedNode = treeViewPointLst.Nodes[pointCloudParam.PointCloudInfoLst.Count - 1];
            UpdatePropertyGrid();
            treeViewPointLst.Refresh();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(treeViewPointLst.SelectedNode != null)
            {
                pointCloudParam.PointCloudInfoLst.RemoveAt(treeViewPointLst.SelectedNode.Index);
                UpdateTreeView();
            }
        }
        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
