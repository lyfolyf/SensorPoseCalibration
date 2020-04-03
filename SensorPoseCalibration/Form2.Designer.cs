namespace SensorPoseCalibration
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("点云0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("点云1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("点云2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("点云3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("点云4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("校正前", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("点云0");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("点云1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("点云2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("点云3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("点云4");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("校正后", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("");
            ComponentLib.ButtonEx.ShapeParam shapeParam1 = new ComponentLib.ButtonEx.ShapeParam();
            ComponentLib.ButtonEx.ShapeParam shapeParam2 = new ComponentLib.ButtonEx.ShapeParam();
            this.panelEx1 = new ComponentLib.PanelEx();
            this.panelEx2 = new ComponentLib.PanelEx();
            this.treeViewCloud = new ComponentLib.TreeViewEx();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelEx2 = new ComponentLib.LabelEx();
            this.propertyGridEx2 = new ComponentLib.PropertyGridEx();
            this.labelEx3 = new ComponentLib.LabelEx();
            this.comboBoxEx1 = new ComponentLib.ComboBoxEx();
            this.propertyGridEx1 = new ComponentLib.PropertyGridEx();
            this.buttonCalibPose = new ComponentLib.ButtonEx();
            this.buttonSavePose = new ComponentLib.ButtonEx();
            this.labelEx1 = new ComponentLib.LabelEx();
            this.menuStripEx1 = new ComponentLib.MenuStripEx();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算姿态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调试窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点云查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title1 = new ComponentLib.Title();
            this.map3D1 = new UserControls.Map3D();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.menuStripEx1.SuspendLayout();
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
            this.panelEx1.Controls.Add(this.map3D1);
            this.panelEx1.Controls.Add(this.treeViewCloud);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Controls.Add(this.menuStripEx1);
            this.panelEx1.Controls.Add(this.title1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.GlobalStyleEnable = false;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(966, 647);
            this.panelEx1.TabIndex = 1;
            // 
            // panelEx2
            // 
            this.panelEx2.BackColor = System.Drawing.Color.White;
            this.panelEx2.BackColorGradient = System.Drawing.Color.Empty;
            this.panelEx2.BackColorTransparent = 0;
            this.panelEx2.BackImage = ((System.Drawing.Image)(resources.GetObject("panelEx2.BackImage")));
            this.panelEx2.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEx2.BoundColorEnable = false;
            this.panelEx2.Controls.Add(this.labelEx2);
            this.panelEx2.Controls.Add(this.propertyGridEx2);
            this.panelEx2.Controls.Add(this.labelEx3);
            this.panelEx2.Controls.Add(this.comboBoxEx1);
            this.panelEx2.Controls.Add(this.propertyGridEx1);
            this.panelEx2.Controls.Add(this.buttonCalibPose);
            this.panelEx2.Controls.Add(this.buttonSavePose);
            this.panelEx2.Controls.Add(this.labelEx1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.GlobalStyleEnable = false;
            this.panelEx2.Location = new System.Drawing.Point(715, 55);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(251, 592);
            this.panelEx2.TabIndex = 5;
            // 
            // treeViewCloud
            // 
            this.treeViewCloud.BackColor = System.Drawing.Color.White;
            this.treeViewCloud.BackColorGradient = System.Drawing.Color.Empty;
            this.treeViewCloud.BackColorTransparent = 0;
            this.treeViewCloud.BackImage = ((System.Drawing.Image)(resources.GetObject("treeViewCloud.BackImage")));
            this.treeViewCloud.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.treeViewCloud.CollapseImageIndex = -1;
            this.treeViewCloud.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewCloud.ExpandImageIndex = -1;
            this.treeViewCloud.ForeColor = System.Drawing.Color.Black;
            this.treeViewCloud.GlobalStyleEnable = false;
            this.treeViewCloud.ImageList = this.imageList1;
            this.treeViewCloud.ItemHeight = 20;
            this.treeViewCloud.Location = new System.Drawing.Point(0, 55);
            this.treeViewCloud.Name = "treeViewCloud";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "点云0";
            treeNode1.Text = "点云0";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "点云1";
            treeNode2.Text = "点云1";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "点云2";
            treeNode3.Text = "点云2";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "点云3";
            treeNode4.Text = "点云3";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "点云4";
            treeNode5.Text = "点云4";
            treeNode6.Name = "校正前";
            treeNode6.Text = "校正前";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "点云0";
            treeNode7.Text = "点云0";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "点云1";
            treeNode8.Text = "点云1";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "点云2";
            treeNode9.Text = "点云2";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "点云3";
            treeNode10.Text = "点云3";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "点云4";
            treeNode11.Text = "点云4";
            treeNode12.Name = "校正后";
            treeNode12.Text = "校正后";
            this.treeViewCloud.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12});
            this.treeViewCloud.ScrollarBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.treeViewCloud.ScrollarTriangleColor = System.Drawing.Color.Black;
            treeNode13.Name = "";
            treeNode13.Text = "";
            this.treeViewCloud.SelectedNode = treeNode13;
            this.treeViewCloud.ShowExpand = true;
            this.treeViewCloud.Size = new System.Drawing.Size(244, 592);
            this.treeViewCloud.TabIndex = 20;
            this.treeViewCloud.Text = "treeViewEx1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "VolumeBlack.png");
            // 
            // labelEx2
            // 
            this.labelEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.labelEx2.BackImage = ((System.Drawing.Image)(resources.GetObject("labelEx2.BackImage")));
            this.labelEx2.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelEx2.BoundColorEnable = false;
            this.labelEx2.ForeColor = System.Drawing.Color.Black;
            this.labelEx2.GlobalStyleEnable = false;
            this.labelEx2.Location = new System.Drawing.Point(3, 313);
            this.labelEx2.Margin = new System.Windows.Forms.Padding(0);
            this.labelEx2.Name = "labelEx2";
            this.labelEx2.Size = new System.Drawing.Size(245, 20);
            this.labelEx2.TabIndex = 19;
            this.labelEx2.Text = "姿态结果";
            // 
            // propertyGridEx2
            // 
            this.propertyGridEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridEx2.BackColor = System.Drawing.Color.White;
            this.propertyGridEx2.BackColorGradient = System.Drawing.Color.Empty;
            this.propertyGridEx2.BackColorTransparent = 100;
            this.propertyGridEx2.BackImage = ((System.Drawing.Image)(resources.GetObject("propertyGridEx2.BackImage")));
            this.propertyGridEx2.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.propertyGridEx2.ButtonBoundColor = System.Drawing.Color.Gray;
            this.propertyGridEx2.CategoryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.propertyGridEx2.ForeColor = System.Drawing.Color.Black;
            this.propertyGridEx2.GlobalStyleEnable = false;
            this.propertyGridEx2.ItemHeight = 20;
            this.propertyGridEx2.Location = new System.Drawing.Point(4, 333);
            this.propertyGridEx2.Margin = new System.Windows.Forms.Padding(0);
            this.propertyGridEx2.Name = "propertyGridEx2";
            this.propertyGridEx2.ScrollarBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.propertyGridEx2.Size = new System.Drawing.Size(245, 192);
            this.propertyGridEx2.TabIndex = 18;
            this.propertyGridEx2.Text = "propertyGridEx2";
            // 
            // labelEx3
            // 
            this.labelEx3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEx3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.labelEx3.BackImage = ((System.Drawing.Image)(resources.GetObject("labelEx3.BackImage")));
            this.labelEx3.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelEx3.BoundColorEnable = false;
            this.labelEx3.ForeColor = System.Drawing.Color.Black;
            this.labelEx3.GlobalStyleEnable = false;
            this.labelEx3.Location = new System.Drawing.Point(3, 52);
            this.labelEx3.Margin = new System.Windows.Forms.Padding(0);
            this.labelEx3.Name = "labelEx3";
            this.labelEx3.Size = new System.Drawing.Size(245, 20);
            this.labelEx3.TabIndex = 14;
            this.labelEx3.Text = "项目配置";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEx1.BackColor = System.Drawing.Color.White;
            this.comboBoxEx1.BackColorTransparent = 100;
            this.comboBoxEx1.BackImage = ((System.Drawing.Image)(resources.GetObject("comboBoxEx1.BackImage")));
            this.comboBoxEx1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.comboBoxEx1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboBoxEx1.ButtonGradientColor = System.Drawing.Color.Empty;
            this.comboBoxEx1.ButtonTriangleColor = System.Drawing.Color.Black;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.GlobalStyleEnable = false;
            this.comboBoxEx1.Location = new System.Drawing.Point(3, 22);
            this.comboBoxEx1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.SelectedItem = null;
            this.comboBoxEx1.Size = new System.Drawing.Size(245, 21);
            this.comboBoxEx1.TabIndex = 15;
            this.comboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
            // 
            // propertyGridEx1
            // 
            this.propertyGridEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridEx1.BackColor = System.Drawing.Color.White;
            this.propertyGridEx1.BackColorGradient = System.Drawing.Color.Empty;
            this.propertyGridEx1.BackColorTransparent = 100;
            this.propertyGridEx1.BackImage = ((System.Drawing.Image)(resources.GetObject("propertyGridEx1.BackImage")));
            this.propertyGridEx1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.propertyGridEx1.ButtonBoundColor = System.Drawing.Color.Gray;
            this.propertyGridEx1.CategoryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.propertyGridEx1.ForeColor = System.Drawing.Color.Black;
            this.propertyGridEx1.GlobalStyleEnable = false;
            this.propertyGridEx1.ItemHeight = 20;
            this.propertyGridEx1.Location = new System.Drawing.Point(3, 72);
            this.propertyGridEx1.Margin = new System.Windows.Forms.Padding(0);
            this.propertyGridEx1.Name = "propertyGridEx1";
            this.propertyGridEx1.ScrollarBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.propertyGridEx1.Size = new System.Drawing.Size(245, 185);
            this.propertyGridEx1.TabIndex = 13;
            this.propertyGridEx1.Text = "propertyGridEx1";
            // 
            // buttonCalibPose
            // 
            this.buttonCalibPose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalibPose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCalibPose.BackColorGradient = System.Drawing.Color.Empty;
            this.buttonCalibPose.BackColorTransparent = 100;
            this.buttonCalibPose.BackImage = ((System.Drawing.Image)(resources.GetObject("buttonCalibPose.BackImage")));
            this.buttonCalibPose.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCalibPose.ForeColor = System.Drawing.Color.Black;
            this.buttonCalibPose.GlobalStyleEnable = false;
            this.buttonCalibPose.Location = new System.Drawing.Point(4, 274);
            this.buttonCalibPose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCalibPose.Name = "buttonCalibPose";
            shapeParam1.bottomLeft = 2;
            shapeParam1.bottomRight = 2;
            shapeParam1.clientHeight = 25;
            shapeParam1.clientWidth = 243;
            shapeParam1.topLeft = 2;
            shapeParam1.topRight = 2;
            shapeParam1.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonCalibPose.Shape = shapeParam1;
            this.buttonCalibPose.Size = new System.Drawing.Size(243, 25);
            this.buttonCalibPose.TabIndex = 16;
            this.buttonCalibPose.Text = "计算姿态";
            this.buttonCalibPose.UseVisualStyleBackColor = false;
            this.buttonCalibPose.Click += new System.EventHandler(this.buttonCalibPose_Click);
            // 
            // buttonSavePose
            // 
            this.buttonSavePose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonSavePose.BackColorGradient = System.Drawing.Color.Empty;
            this.buttonSavePose.BackColorTransparent = 100;
            this.buttonSavePose.BackImage = ((System.Drawing.Image)(resources.GetObject("buttonSavePose.BackImage")));
            this.buttonSavePose.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSavePose.ForeColor = System.Drawing.Color.Black;
            this.buttonSavePose.GlobalStyleEnable = false;
            this.buttonSavePose.Location = new System.Drawing.Point(4, 538);
            this.buttonSavePose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSavePose.Name = "buttonSavePose";
            shapeParam2.bottomLeft = 2;
            shapeParam2.bottomRight = 2;
            shapeParam2.clientHeight = 25;
            shapeParam2.clientWidth = 244;
            shapeParam2.topLeft = 2;
            shapeParam2.topRight = 2;
            shapeParam2.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonSavePose.Shape = shapeParam2;
            this.buttonSavePose.Size = new System.Drawing.Size(244, 25);
            this.buttonSavePose.TabIndex = 17;
            this.buttonSavePose.Text = "保存姿态";
            this.buttonSavePose.UseVisualStyleBackColor = false;
            this.buttonSavePose.Click += new System.EventHandler(this.buttonSavePose_Click);
            // 
            // labelEx1
            // 
            this.labelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.labelEx1.BackImage = ((System.Drawing.Image)(resources.GetObject("labelEx1.BackImage")));
            this.labelEx1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelEx1.BoundColorEnable = false;
            this.labelEx1.ForeColor = System.Drawing.Color.Black;
            this.labelEx1.GlobalStyleEnable = false;
            this.labelEx1.Location = new System.Drawing.Point(3, 2);
            this.labelEx1.Margin = new System.Windows.Forms.Padding(0);
            this.labelEx1.Name = "labelEx1";
            this.labelEx1.Size = new System.Drawing.Size(245, 20);
            this.labelEx1.TabIndex = 7;
            this.labelEx1.Text = "项目选择";
            // 
            // menuStripEx1
            // 
            this.menuStripEx1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStripEx1.BackColorGradient = System.Drawing.Color.Empty;
            this.menuStripEx1.BackColorTransparent = 0;
            this.menuStripEx1.BackImage = ((System.Drawing.Image)(resources.GetObject("menuStripEx1.BackImage")));
            this.menuStripEx1.GlobalStyleEnable = false;
            this.menuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.运行RToolStripMenuItem,
            this.视图VToolStripMenuItem,
            this.项目管理MToolStripMenuItem});
            this.menuStripEx1.Location = new System.Drawing.Point(0, 30);
            this.menuStripEx1.Name = "menuStripEx1";
            this.menuStripEx1.Size = new System.Drawing.Size(966, 25);
            this.menuStripEx1.TabIndex = 9;
            this.menuStripEx1.Text = "menuStripEx1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载配置ToolStripMenuItem,
            this.保存配置ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 加载配置ToolStripMenuItem
            // 
            this.加载配置ToolStripMenuItem.Name = "加载配置ToolStripMenuItem";
            this.加载配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.加载配置ToolStripMenuItem.Text = "加载配置";
            this.加载配置ToolStripMenuItem.Click += new System.EventHandler(this.加载配置ToolStripMenuItem_Click);
            // 
            // 保存配置ToolStripMenuItem
            // 
            this.保存配置ToolStripMenuItem.Name = "保存配置ToolStripMenuItem";
            this.保存配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存配置ToolStripMenuItem.Text = "保存配置";
            this.保存配置ToolStripMenuItem.Click += new System.EventHandler(this.保存配置ToolStripMenuItem_Click);
            // 
            // 运行RToolStripMenuItem
            // 
            this.运行RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算姿态ToolStripMenuItem,
            this.保存结果ToolStripMenuItem});
            this.运行RToolStripMenuItem.Name = "运行RToolStripMenuItem";
            this.运行RToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.运行RToolStripMenuItem.Text = "运行(&R)";
            // 
            // 计算姿态ToolStripMenuItem
            // 
            this.计算姿态ToolStripMenuItem.Name = "计算姿态ToolStripMenuItem";
            this.计算姿态ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.计算姿态ToolStripMenuItem.Text = "计算姿态";
            // 
            // 保存结果ToolStripMenuItem
            // 
            this.保存结果ToolStripMenuItem.Name = "保存结果ToolStripMenuItem";
            this.保存结果ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存结果ToolStripMenuItem.Text = "保存结果";
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.调试窗口ToolStripMenuItem,
            this.点云查看ToolStripMenuItem});
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // 调试窗口ToolStripMenuItem
            // 
            this.调试窗口ToolStripMenuItem.Checked = true;
            this.调试窗口ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.调试窗口ToolStripMenuItem.Name = "调试窗口ToolStripMenuItem";
            this.调试窗口ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.调试窗口ToolStripMenuItem.Text = "结果视图";
            this.调试窗口ToolStripMenuItem.Click += new System.EventHandler(this.调试窗口ToolStripMenuItem_Click);
            // 
            // 点云查看ToolStripMenuItem
            // 
            this.点云查看ToolStripMenuItem.Name = "点云查看ToolStripMenuItem";
            this.点云查看ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.点云查看ToolStripMenuItem.Text = "点云查看";
            this.点云查看ToolStripMenuItem.Click += new System.EventHandler(this.点云查看ToolStripMenuItem_Click);
            // 
            // 项目管理MToolStripMenuItem
            // 
            this.项目管理MToolStripMenuItem.Name = "项目管理MToolStripMenuItem";
            this.项目管理MToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.项目管理MToolStripMenuItem.Text = "项目管理(&M)";
            this.项目管理MToolStripMenuItem.Click += new System.EventHandler(this.项目管理MToolStripMenuItem_Click);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.White;
            this.title1.BackColorGradient = System.Drawing.Color.Empty;
            this.title1.BackColorTransparent = 50;
            this.title1.BackImage = ((System.Drawing.Image)(resources.GetObject("title1.BackImage")));
            this.title1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1.ForeColor = System.Drawing.Color.Black;
            this.title1.GlobalStyleEnable = false;
            this.title1.IconImage = null;
            this.title1.Location = new System.Drawing.Point(0, 0);
            this.title1.MaximizeBox = true;
            this.title1.MinimizeBox = true;
            this.title1.Name = "title1";
            this.title1.TabIndex = 0;
            this.title1.Text = "Sensor Pose Calibration";
            this.title1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.title1.TitleHeight = 30;
            // 
            // map3D1
            // 
            this.map3D1.AxisColorX = System.Drawing.Color.Red;
            this.map3D1.AxisColorY = System.Drawing.Color.Green;
            this.map3D1.AxisColorZ = System.Drawing.Color.Blue;
            this.map3D1.bResetTrackBall = false;
            this.map3D1.ColorDisMax = 5D;
            this.map3D1.ColorDisMin = -5D;
            this.map3D1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.map3D1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map3D1.EnableMouseEvents = true;
            this.map3D1.EnableZoom = true;
            this.map3D1.ForeColor = System.Drawing.Color.Yellow;
            this.map3D1.GridCellCount = 10;
            this.map3D1.GridShowXY = false;
            this.map3D1.GridShowXZ = false;
            this.map3D1.GridShowYZ = false;
            this.map3D1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.map3D1.IsUseTexture = false;
            this.map3D1.Location = new System.Drawing.Point(244, 55);
            this.map3D1.Name = "map3D1";
            this.map3D1.PixelsPerMM = 50D;
            this.map3D1.Size = new System.Drawing.Size(471, 592);
            this.map3D1.TabIndex = 21;
            this.map3D1.Tag = "";
            this.map3D1.ViewMode = CommonStruct.Type3D.ViewMode.Default;
            this.map3D1.Zoom = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 647);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.menuStripEx1.ResumeLayout(false);
            this.menuStripEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentLib.PanelEx panelEx1;
        private ComponentLib.Title title1;
        private ComponentLib.PanelEx panelEx2;
        private ComponentLib.TreeViewEx treeViewCloud;
        private ComponentLib.LabelEx labelEx2;
        private ComponentLib.PropertyGridEx propertyGridEx2;
        private ComponentLib.LabelEx labelEx3;
        private ComponentLib.ComboBoxEx comboBoxEx1;
        private ComponentLib.PropertyGridEx propertyGridEx1;
        private ComponentLib.ButtonEx buttonCalibPose;
        private ComponentLib.ButtonEx buttonSavePose;
        private ComponentLib.LabelEx labelEx1;
        private ComponentLib.MenuStripEx menuStripEx1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算姿态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存结果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调试窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点云查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目管理MToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private UserControls.Map3D map3D1;
    }
}