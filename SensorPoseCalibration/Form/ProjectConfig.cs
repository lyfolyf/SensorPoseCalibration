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
    public partial class ProjectConfig : Form
    {

        ParamManager _paramManager;
        public ProjectConfig(ParamManager manager)
        {
            _paramManager = manager;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            List<string> projectLst = _paramManager.GetAllParamNames();
            treeViewProjectLst.Nodes.Clear();
            foreach (var item in projectLst)
                treeViewProjectLst.Nodes.Add(item);
            if (projectLst.Count > 0)
                treeViewProjectLst.SelectedNode = treeViewProjectLst.Nodes[0];
            else
                treeViewProjectLst.SelectedNode = null;
            treeViewProjectLst.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewProject newForm = new NewProject();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                if (_paramManager.AddParam(newForm.projectName))
                {
                    treeViewProjectLst.Nodes.Add(newForm.projectName);
                    treeViewProjectLst.SelectedNode = treeViewProjectLst.Nodes[treeViewProjectLst.Nodes.Count - 1];
                    treeViewProjectLst.Refresh();
                }
                else
                    MessageBox.Show("已存在项目" + newForm.projectName + ",新增失败！");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (treeViewProjectLst.SelectedNode != null)
            {
                _paramManager.RemoveParam(treeViewProjectLst.SelectedNode.Text);
                treeViewProjectLst.Nodes.Remove(treeViewProjectLst.SelectedNode);
                UpdateTreeView();
            }
        }
    }
}
