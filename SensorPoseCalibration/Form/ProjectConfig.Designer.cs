namespace SensorPoseCalibration
{
    partial class ProjectConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            this.panelEx1 = new ComponentLib.PanelEx();
            this.buttonRemove = new ComponentLib.ButtonEx();
            this.buttonAdd = new ComponentLib.ButtonEx();
            this.treeViewProjectLst = new ComponentLib.TreeViewEx();
            this.title1 = new ComponentLib.Title();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.BackColor = System.Drawing.Color.Transparent;
            this.panelEx1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx1.BoundStyle = ComponentLib.PanelEx.PanelDashStyle.Solid;
            this.panelEx1.ControlFace = System.Drawing.Color.White;
            this.panelEx1.Controls.Add(this.buttonRemove);
            this.panelEx1.Controls.Add(this.buttonAdd);
            this.panelEx1.Controls.Add(this.treeViewProjectLst);
            this.panelEx1.Controls.Add(this.title1);
            this.panelEx1.CornerBottomLeft = 3;
            this.panelEx1.CornerBottomRight = 3;
            this.panelEx1.CornerTopLeft = 3;
            this.panelEx1.CornerTopRight = 3;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.GlobalStyleEnable = false;
            this.panelEx1.GradientColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(225, 285);
            this.panelEx1.TabIndex = 1;
            this.panelEx1.Transparency = 100;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonRemove.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonRemove.ControlFace = System.Drawing.Color.White;
            this.buttonRemove.CornerBottomLeft = 3;
            this.buttonRemove.CornerBottomRight = 3;
            this.buttonRemove.CornerTopLeft = 3;
            this.buttonRemove.CornerTopRight = 3;
            this.buttonRemove.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonRemove.ForeColor = System.Drawing.Color.Black;
            this.buttonRemove.GlobalStyleEnable = false;
            this.buttonRemove.GradientColor = System.Drawing.Color.Empty;
            this.buttonRemove.Image = null;
            this.buttonRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonRemove.Location = new System.Drawing.Point(120, 250);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(87, 25);
            this.buttonRemove.SpaceWidth = 0;
            this.buttonRemove.TabIndex = 24;
            this.buttonRemove.Text = "移除项目";
            this.buttonRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonRemove.Transparency = 100;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonAdd.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonAdd.ControlFace = System.Drawing.Color.White;
            this.buttonAdd.CornerBottomLeft = 3;
            this.buttonAdd.CornerBottomRight = 3;
            this.buttonAdd.CornerTopLeft = 3;
            this.buttonAdd.CornerTopRight = 3;
            this.buttonAdd.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.GlobalStyleEnable = false;
            this.buttonAdd.GradientColor = System.Drawing.Color.Empty;
            this.buttonAdd.Image = null;
            this.buttonAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonAdd.Location = new System.Drawing.Point(12, 250);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 25);
            this.buttonAdd.SpaceWidth = 0;
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "添加项目";
            this.buttonAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonAdd.Transparency = 100;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // treeViewProjectLst
            // 
            this.treeViewProjectLst.BackColor = System.Drawing.Color.Transparent;
            this.treeViewProjectLst.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.treeViewProjectLst.CollapseImageIndex = -1;
            this.treeViewProjectLst.ControlFace = System.Drawing.Color.White;
            this.treeViewProjectLst.ExpandImageIndex = -1;
            this.treeViewProjectLst.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.treeViewProjectLst.ForeColor = System.Drawing.Color.Black;
            this.treeViewProjectLst.GlobalStyleEnable = false;
            this.treeViewProjectLst.GradientColor = System.Drawing.Color.Empty;
            this.treeViewProjectLst.ItemHeight = 20;
            this.treeViewProjectLst.Location = new System.Drawing.Point(4, 32);
            this.treeViewProjectLst.Name = "treeViewProjectLst";
            this.treeViewProjectLst.ScrollarBarColor = System.Drawing.Color.Gray;
            this.treeViewProjectLst.ScrollarTriangleColor = System.Drawing.Color.Black;
            treeNode1.Name = "";
            treeNode1.Text = "";
            this.treeViewProjectLst.SelectedNode = treeNode1;
            this.treeViewProjectLst.ShowExpand = false;
            this.treeViewProjectLst.Size = new System.Drawing.Size(218, 210);
            this.treeViewProjectLst.TabIndex = 22;
            this.treeViewProjectLst.Text = "treeViewEx1";
            this.treeViewProjectLst.Transparency = 100;
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.Transparent;
            this.title1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.ControlFace = System.Drawing.Color.White;
            this.title1.CornerBottomLeft = 0;
            this.title1.CornerBottomRight = 0;
            this.title1.CornerTopLeft = 0;
            this.title1.CornerTopRight = 0;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.title1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1.ForeColor = System.Drawing.Color.Black;
            this.title1.FunctionColor = System.Drawing.Color.Black;
            this.title1.GlobalStyleEnable = false;
            this.title1.GradientColor = System.Drawing.Color.Empty;
            this.title1.IconImage = null;
            this.title1.Location = new System.Drawing.Point(0, 0);
            this.title1.Name = "title1";
            this.title1.ShowFunctionBox = true;
            this.title1.ShowMaxMinBox = true;
            this.title1.Size = new System.Drawing.Size(225, 30);
            this.title1.TabIndex = 0;
            this.title1.Text = "Project Config";
            this.title1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.title1.TitleHeight = 30;
            this.title1.Transparency = 100;
            // 
            // ProjectConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 285);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectConfig";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentLib.PanelEx panelEx1;
        private ComponentLib.ButtonEx buttonRemove;
        private ComponentLib.ButtonEx buttonAdd;
        private ComponentLib.TreeViewEx treeViewProjectLst;
        private ComponentLib.Title title1;
    }
}