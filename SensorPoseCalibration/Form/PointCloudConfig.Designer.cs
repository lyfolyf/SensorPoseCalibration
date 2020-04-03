namespace SensorPoseCalibration
{
    partial class PointCloudConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointCloudConfig));
            ComponentLib.ButtonEx.ShapeParam shapeParam1 = new ComponentLib.ButtonEx.ShapeParam();
            ComponentLib.ButtonEx.ShapeParam shapeParam2 = new ComponentLib.ButtonEx.ShapeParam();
            ComponentLib.ButtonEx.ShapeParam shapeParam3 = new ComponentLib.ButtonEx.ShapeParam();
            ComponentLib.ButtonEx.ShapeParam shapeParam4 = new ComponentLib.ButtonEx.ShapeParam();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            this.panelEx1 = new ComponentLib.PanelEx();
            this.buttonCancel = new ComponentLib.ButtonEx();
            this.buttonOK = new ComponentLib.ButtonEx();
            this.buttonRemove = new ComponentLib.ButtonEx();
            this.buttonAdd = new ComponentLib.ButtonEx();
            this.treeViewPointLst = new ComponentLib.TreeViewEx();
            this.propertyGridEdit = new ComponentLib.PropertyGridEx();
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
            this.panelEx1.Controls.Add(this.buttonCancel);
            this.panelEx1.Controls.Add(this.buttonOK);
            this.panelEx1.Controls.Add(this.buttonRemove);
            this.panelEx1.Controls.Add(this.buttonAdd);
            this.panelEx1.Controls.Add(this.treeViewPointLst);
            this.panelEx1.Controls.Add(this.propertyGridEdit);
            this.panelEx1.Controls.Add(this.title1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.GlobalStyleEnable = false;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(512, 324);
            this.panelEx1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.buttonCancel.BackColorGradient = System.Drawing.Color.Empty;
            this.buttonCancel.BackColorTransparent = 100;
            this.buttonCancel.BackImage = ((System.Drawing.Image)(resources.GetObject("buttonCancel.BackImage")));
            this.buttonCancel.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.GlobalStyleEnable = false;
            this.buttonCancel.Location = new System.Drawing.Point(406, 293);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            shapeParam1.bottomLeft = 2;
            shapeParam1.bottomRight = 2;
            shapeParam1.clientHeight = 25;
            shapeParam1.clientWidth = 103;
            shapeParam1.topLeft = 2;
            shapeParam1.topRight = 2;
            shapeParam1.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonCancel.Shape = shapeParam1;
            this.buttonCancel.Size = new System.Drawing.Size(103, 25);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.buttonOK.BackColorGradient = System.Drawing.Color.Empty;
            this.buttonOK.BackColorTransparent = 100;
            this.buttonOK.BackImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackImage")));
            this.buttonOK.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOK.ForeColor = System.Drawing.Color.Black;
            this.buttonOK.GlobalStyleEnable = false;
            this.buttonOK.Location = new System.Drawing.Point(291, 293);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOK.Name = "buttonOK";
            shapeParam2.bottomLeft = 2;
            shapeParam2.bottomRight = 2;
            shapeParam2.clientHeight = 25;
            shapeParam2.clientWidth = 102;
            shapeParam2.topLeft = 2;
            shapeParam2.topRight = 2;
            shapeParam2.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonOK.Shape = shapeParam2;
            this.buttonOK.Size = new System.Drawing.Size(102, 25);
            this.buttonOK.TabIndex = 25;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
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
            shapeParam3.bottomLeft = 2;
            shapeParam3.bottomRight = 2;
            shapeParam3.clientHeight = 25;
            shapeParam3.clientWidth = 87;
            shapeParam3.topLeft = 2;
            shapeParam3.topRight = 2;
            shapeParam3.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonRemove.Shape = shapeParam3;
            this.buttonRemove.Size = new System.Drawing.Size(87, 25);
            this.buttonRemove.TabIndex = 24;
            this.buttonRemove.Text = "移除点云";
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
            shapeParam4.bottomLeft = 2;
            shapeParam4.bottomRight = 2;
            shapeParam4.clientHeight = 25;
            shapeParam4.clientWidth = 94;
            shapeParam4.topLeft = 2;
            shapeParam4.topRight = 2;
            shapeParam4.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonAdd.Shape = shapeParam4;
            this.buttonAdd.Size = new System.Drawing.Size(94, 25);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "添加点云";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // treeViewPointLst
            // 
            this.treeViewPointLst.BackColor = System.Drawing.Color.White;
            this.treeViewPointLst.BackColorGradient = System.Drawing.Color.Empty;
            this.treeViewPointLst.BackColorTransparent = 0;
            this.treeViewPointLst.BackImage = ((System.Drawing.Image)(resources.GetObject("treeViewPointLst.BackImage")));
            this.treeViewPointLst.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.treeViewPointLst.CollapseImageIndex = -1;
            this.treeViewPointLst.ExpandImageIndex = -1;
            this.treeViewPointLst.ForeColor = System.Drawing.Color.Black;
            this.treeViewPointLst.GlobalStyleEnable = false;
            this.treeViewPointLst.ItemHeight = 20;
            this.treeViewPointLst.Location = new System.Drawing.Point(3, 31);
            this.treeViewPointLst.Name = "treeViewPointLst";
            this.treeViewPointLst.ScrollarBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.treeViewPointLst.ScrollarTriangleColor = System.Drawing.Color.Black;
            treeNode1.Name = "";
            treeNode1.Text = "";
            this.treeViewPointLst.SelectedNode = treeNode1;
            this.treeViewPointLst.ShowExpand = false;
            this.treeViewPointLst.Size = new System.Drawing.Size(218, 210);
            this.treeViewPointLst.TabIndex = 22;
            this.treeViewPointLst.Text = "treeViewEx1";
            this.treeViewPointLst.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPointLst_NodeMouseClick);
            // 
            // propertyGridEdit
            // 
            this.propertyGridEdit.BackColor = System.Drawing.Color.White;
            this.propertyGridEdit.BackColorGradient = System.Drawing.Color.Empty;
            this.propertyGridEdit.BackColorTransparent = 100;
            this.propertyGridEdit.BackImage = ((System.Drawing.Image)(resources.GetObject("propertyGridEdit.BackImage")));
            this.propertyGridEdit.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.propertyGridEdit.ButtonBoundColor = System.Drawing.Color.Gray;
            this.propertyGridEdit.CategoryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.propertyGridEdit.ForeColor = System.Drawing.Color.Black;
            this.propertyGridEdit.GlobalStyleEnable = false;
            this.propertyGridEdit.ItemHeight = 20;
            this.propertyGridEdit.Location = new System.Drawing.Point(222, 31);
            this.propertyGridEdit.Name = "propertyGridEdit";
            this.propertyGridEdit.ScrollarBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.propertyGridEdit.Size = new System.Drawing.Size(287, 253);
            this.propertyGridEdit.TabIndex = 2;
            this.propertyGridEdit.Text = "propertyGridEx1";
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
            this.title1.Text = "PointCloud Config";
            this.title1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.title1.TitleHeight = 30;
            // 
            // PointCloudConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 324);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PointCloudConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PointCloudConfig";
            this.Load += new System.EventHandler(this.PointCloudConfig_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentLib.PanelEx panelEx1;
        private ComponentLib.PropertyGridEx propertyGridEdit;
        private ComponentLib.Title title1;
        private ComponentLib.ButtonEx buttonCancel;
        private ComponentLib.ButtonEx buttonOK;
        private ComponentLib.ButtonEx buttonRemove;
        private ComponentLib.ButtonEx buttonAdd;
        private ComponentLib.TreeViewEx treeViewPointLst;
    }
}