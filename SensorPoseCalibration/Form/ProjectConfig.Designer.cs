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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectConfig));
            ComponentLib.ButtonEx.ShapeParam shapeParam1 = new ComponentLib.ButtonEx.ShapeParam();
            ComponentLib.ButtonEx.ShapeParam shapeParam2 = new ComponentLib.ButtonEx.ShapeParam();
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
            this.panelEx1.BackColor = System.Drawing.Color.White;
            this.panelEx1.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelEx1.BackColorTransparent = 100;
            this.panelEx1.BackImage = ((System.Drawing.Image)(resources.GetObject("panelEx1.BackImage")));
            this.panelEx1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEx1.BoundColorEnable = false;
            this.panelEx1.Controls.Add(this.buttonRemove);
            this.panelEx1.Controls.Add(this.buttonAdd);
            this.panelEx1.Controls.Add(this.treeViewProjectLst);
            this.panelEx1.Controls.Add(this.title1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.GlobalStyleEnable = false;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(225, 285);
            this.panelEx1.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.buttonRemove.BackColorGradient = System.Drawing.Color.Empty;
            this.buttonRemove.BackColorTransparent = 100;
            this.buttonRemove.BackImage = ((System.Drawing.Image)(resources.GetObject("buttonRemove.BackImage")));
            this.buttonRemove.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRemove.ForeColor = System.Drawing.Color.Black;
            this.buttonRemove.GlobalStyleEnable = false;
            this.buttonRemove.Location = new System.Drawing.Point(120, 250);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            shapeParam1.bottomLeft = 2;
            shapeParam1.bottomRight = 2;
            shapeParam1.clientHeight = 25;
            shapeParam1.clientWidth = 87;
            shapeParam1.topLeft = 2;
            shapeParam1.topRight = 2;
            shapeParam1.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonRemove.Shape = shapeParam1;
            this.buttonRemove.Size = new System.Drawing.Size(87, 25);
            this.buttonRemove.TabIndex = 24;
            this.buttonRemove.Text = "移除项目";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.buttonAdd.BackColorGradient = System.Drawing.Color.Empty;
            this.buttonAdd.BackColorTransparent = 100;
            this.buttonAdd.BackImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackImage")));
            this.buttonAdd.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.GlobalStyleEnable = false;
            this.buttonAdd.Location = new System.Drawing.Point(12, 250);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            shapeParam2.bottomLeft = 2;
            shapeParam2.bottomRight = 2;
            shapeParam2.clientHeight = 25;
            shapeParam2.clientWidth = 94;
            shapeParam2.topLeft = 2;
            shapeParam2.topRight = 2;
            shapeParam2.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonAdd.Shape = shapeParam2;
            this.buttonAdd.Size = new System.Drawing.Size(94, 25);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "添加项目";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // treeViewProjectLst
            // 
            this.treeViewProjectLst.BackColor = System.Drawing.Color.White;
            this.treeViewProjectLst.BackColorGradient = System.Drawing.Color.Empty;
            this.treeViewProjectLst.BackColorTransparent = 0;
            this.treeViewProjectLst.BackImage = ((System.Drawing.Image)(resources.GetObject("treeViewProjectLst.BackImage")));
            this.treeViewProjectLst.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.treeViewProjectLst.CollapseImageIndex = -1;
            this.treeViewProjectLst.ExpandImageIndex = -1;
            this.treeViewProjectLst.ForeColor = System.Drawing.Color.Black;
            this.treeViewProjectLst.GlobalStyleEnable = false;
            this.treeViewProjectLst.ItemHeight = 20;
            this.treeViewProjectLst.Location = new System.Drawing.Point(3, 31);
            this.treeViewProjectLst.Name = "treeViewProjectLst";
            this.treeViewProjectLst.ScrollarBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.treeViewProjectLst.ScrollarTriangleColor = System.Drawing.Color.Black;
            treeNode1.Name = "";
            treeNode1.Text = "";
            this.treeViewProjectLst.SelectedNode = treeNode1;
            this.treeViewProjectLst.ShowExpand = false;
            this.treeViewProjectLst.Size = new System.Drawing.Size(218, 210);
            this.treeViewProjectLst.TabIndex = 22;
            this.treeViewProjectLst.Text = "treeViewEx1";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.White;
            this.title1.BackColorGradient = System.Drawing.Color.Empty;
            this.title1.BackColorTransparent = 100;
            this.title1.BackImage = ((System.Drawing.Image)(resources.GetObject("title1.BackImage")));
            this.title1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1.ForeColor = System.Drawing.Color.Black;
            this.title1.GlobalStyleEnable = false;
            this.title1.IconImage = null;
            this.title1.Location = new System.Drawing.Point(0, 0);
            this.title1.MaximizeBox = false;
            this.title1.MinimizeBox = false;
            this.title1.Name = "title1";
            this.title1.TabIndex = 0;
            this.title1.Text = "Project Config";
            this.title1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.title1.TitleHeight = 30;
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