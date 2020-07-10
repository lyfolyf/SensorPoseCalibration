namespace SensorPoseCalibration
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelEx1 = new ComponentLib.PanelEx();
            this.map3D1 = new UserControls.Map3D();
            this.panelEx3 = new ComponentLib.PanelEx();
            this.labelEx4 = new ComponentLib.LabelEx();
            this.propertyGridEx3 = new ComponentLib.PropertyGridEx();
            this.treeViewCloud = new ComponentLib.TreeViewEx();
            this.panelEx2 = new ComponentLib.PanelEx();
            this.labelEx2 = new ComponentLib.LabelEx();
            this.propertyGridEx2 = new ComponentLib.PropertyGridEx();
            this.labelEx3 = new ComponentLib.LabelEx();
            this.comboBoxEx1 = new ComponentLib.ComboBoxEx();
            this.propertyGridEx1 = new ComponentLib.PropertyGridEx();
            this.buttonCalibPose = new ComponentLib.ButtonEx();
            this.buttonSavePose = new ComponentLib.ButtonEx();
            this.labelEx1 = new ComponentLib.LabelEx();
            this.panelEx4 = new ComponentLib.PanelEx();
            this.dataGridViewEx1 = new ComponentLib.DataGridViewEx();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEx5 = new ComponentLib.LabelEx();
            this.panelEx5 = new ComponentLib.PanelEx();
            this.segmentLine3 = new ComponentLib.SegmentLine();
            this.btn_Down_view = new ComponentLib.ButtonEx();
            this.btn_Up_view = new ComponentLib.ButtonEx();
            this.btn_Right_view = new ComponentLib.ButtonEx();
            this.btn_Left_view = new ComponentLib.ButtonEx();
            this.btn_Back_view = new ComponentLib.ButtonEx();
            this.btn_Front_view = new ComponentLib.ButtonEx();
            this.segmentLine2 = new ComponentLib.SegmentLine();
            this.btn_saveas_config = new ComponentLib.ButtonEx();
            this.btn_save_config = new ComponentLib.ButtonEx();
            this.btn_load_config = new ComponentLib.ButtonEx();
            this.segmentLine1 = new ComponentLib.SegmentLine();
            this.menuStripEx1 = new ComponentLib.MenuStripEx();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算姿态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFront = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTop = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.项目管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title1 = new ComponentLib.Title();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.panelEx5.SuspendLayout();
            this.menuStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye.png");
            this.imageList1.Images.SetKeyName(1, "eye2.png");
            // 
            // panelEx1
            // 
            this.panelEx1.BackgroundImage = global::SensorPoseCalibration.Properties.Resources._0757_jpg_wh1200;
            this.panelEx1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEx1.BoundStyle = ComponentLib.PanelEx.PanelDashStyle.Solid;
            this.panelEx1.ControlFace = System.Drawing.Color.White;
            this.panelEx1.Controls.Add(this.map3D1);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Controls.Add(this.panelEx4);
            this.panelEx1.Controls.Add(this.panelEx5);
            this.panelEx1.Controls.Add(this.menuStripEx1);
            this.panelEx1.Controls.Add(this.title1);
            this.panelEx1.CornerBottomLeft = 0;
            this.panelEx1.CornerBottomRight = 0;
            this.panelEx1.CornerTopLeft = 0;
            this.panelEx1.CornerTopRight = 0;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.GlobalStyleEnable = false;
            this.panelEx1.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1160, 700);
            this.panelEx1.TabIndex = 1;
            this.panelEx1.Transparency = 100;
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
            this.map3D1.Location = new System.Drawing.Point(200, 80);
            this.map3D1.Name = "map3D1";
            this.map3D1.PixelsPerMM = 50D;
            this.map3D1.Size = new System.Drawing.Size(709, 497);
            this.map3D1.TabIndex = 21;
            this.map3D1.Tag = "";
            this.map3D1.ViewMode = CommonStruct.Type3D.ViewMode.Default;
            this.map3D1.Zoom = 1D;
            // 
            // panelEx3
            // 
            this.panelEx3.BoundColor = System.Drawing.Color.Empty;
            this.panelEx3.BoundStyle = ComponentLib.PanelEx.PanelDashStyle.Solid;
            this.panelEx3.ControlFace = System.Drawing.Color.White;
            this.panelEx3.Controls.Add(this.labelEx4);
            this.panelEx3.Controls.Add(this.propertyGridEx3);
            this.panelEx3.Controls.Add(this.treeViewCloud);
            this.panelEx3.CornerBottomLeft = 0;
            this.panelEx3.CornerBottomRight = 0;
            this.panelEx3.CornerTopLeft = 0;
            this.panelEx3.CornerTopRight = 0;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx3.GlobalStyleEnable = false;
            this.panelEx3.GradientColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(0, 80);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(200, 497);
            this.panelEx3.TabIndex = 22;
            this.panelEx3.Transparency = 100;
            // 
            // labelEx4
            // 
            this.labelEx4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEx4.BackColor = System.Drawing.Color.Transparent;
            this.labelEx4.BoundColor = System.Drawing.Color.Empty;
            this.labelEx4.ControlFace = System.Drawing.Color.White;
            this.labelEx4.CornerBottomLeft = 0;
            this.labelEx4.CornerBottomRight = 0;
            this.labelEx4.CornerTopLeft = 0;
            this.labelEx4.CornerTopRight = 0;
            this.labelEx4.ForeColor = System.Drawing.Color.Black;
            this.labelEx4.GlobalStyleEnable = false;
            this.labelEx4.GradientColor = System.Drawing.Color.Empty;
            this.labelEx4.Location = new System.Drawing.Point(2, 296);
            this.labelEx4.Margin = new System.Windows.Forms.Padding(0);
            this.labelEx4.Name = "labelEx4";
            this.labelEx4.Size = new System.Drawing.Size(196, 20);
            this.labelEx4.TabIndex = 22;
            this.labelEx4.Text = "点云参数";
            this.labelEx4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEx4.Transparency = 255;
            // 
            // propertyGridEx3
            // 
            this.propertyGridEx3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridEx3.BackColor = System.Drawing.Color.Transparent;
            this.propertyGridEx3.ButtonBackColor = System.Drawing.Color.Gray;
            this.propertyGridEx3.ButtonBoundColor = System.Drawing.Color.Gray;
            this.propertyGridEx3.CategoryBackColor = System.Drawing.Color.White;
            this.propertyGridEx3.ControlFace = System.Drawing.Color.White;
            this.propertyGridEx3.DescribTransparency = 255;
            this.propertyGridEx3.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.propertyGridEx3.ForeColor = System.Drawing.Color.Black;
            this.propertyGridEx3.GlobalStyleEnable = false;
            this.propertyGridEx3.GradientColor = System.Drawing.Color.Empty;
            this.propertyGridEx3.ItemHeight = 20;
            this.propertyGridEx3.Location = new System.Drawing.Point(2, 316);
            this.propertyGridEx3.Margin = new System.Windows.Forms.Padding(0);
            this.propertyGridEx3.Name = "propertyGridEx3";
            this.propertyGridEx3.ScrollarBarColor = System.Drawing.Color.Gray;
            this.propertyGridEx3.Size = new System.Drawing.Size(196, 165);
            this.propertyGridEx3.TabIndex = 21;
            this.propertyGridEx3.Text = "propertyGridEx3";
            this.propertyGridEx3.Transparency = 100;
            // 
            // treeViewCloud
            // 
            this.treeViewCloud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewCloud.BackColor = System.Drawing.Color.Transparent;
            this.treeViewCloud.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.treeViewCloud.CollapseImageIndex = -1;
            this.treeViewCloud.ControlFace = System.Drawing.Color.White;
            this.treeViewCloud.ExpandImageIndex = -1;
            this.treeViewCloud.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.treeViewCloud.ForeColor = System.Drawing.Color.Black;
            this.treeViewCloud.GlobalStyleEnable = false;
            this.treeViewCloud.GradientColor = System.Drawing.Color.Empty;
            this.treeViewCloud.ImageList = this.imageList1;
            this.treeViewCloud.ItemHeight = 20;
            this.treeViewCloud.Location = new System.Drawing.Point(2, 3);
            this.treeViewCloud.Name = "treeViewCloud";
            this.treeViewCloud.ScrollarBarColor = System.Drawing.Color.Gray;
            this.treeViewCloud.ScrollarTriangleColor = System.Drawing.Color.Black;
            treeNode2.Name = "";
            treeNode2.Text = "";
            this.treeViewCloud.SelectedNode = treeNode2;
            this.treeViewCloud.ShowExpand = true;
            this.treeViewCloud.Size = new System.Drawing.Size(196, 279);
            this.treeViewCloud.TabIndex = 20;
            this.treeViewCloud.Text = "treeViewEx1";
            this.treeViewCloud.Transparency = 100;
            this.treeViewCloud.OnNodeImageClick += new ComponentLib.TreeViewEx.NodeImageClickDelegate(this.treeViewCloud_OnNodeImageClick);
            this.treeViewCloud.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCloud_NodeMouseClick);
            // 
            // panelEx2
            // 
            this.panelEx2.BackColor = System.Drawing.Color.Transparent;
            this.panelEx2.BoundColor = System.Drawing.Color.Empty;
            this.panelEx2.BoundStyle = ComponentLib.PanelEx.PanelDashStyle.Solid;
            this.panelEx2.ControlFace = System.Drawing.Color.White;
            this.panelEx2.Controls.Add(this.labelEx2);
            this.panelEx2.Controls.Add(this.propertyGridEx2);
            this.panelEx2.Controls.Add(this.labelEx3);
            this.panelEx2.Controls.Add(this.comboBoxEx1);
            this.panelEx2.Controls.Add(this.propertyGridEx1);
            this.panelEx2.Controls.Add(this.buttonCalibPose);
            this.panelEx2.Controls.Add(this.buttonSavePose);
            this.panelEx2.Controls.Add(this.labelEx1);
            this.panelEx2.CornerBottomLeft = 0;
            this.panelEx2.CornerBottomRight = 0;
            this.panelEx2.CornerTopLeft = 0;
            this.panelEx2.CornerTopRight = 0;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.GlobalStyleEnable = false;
            this.panelEx2.GradientColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(909, 80);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(251, 497);
            this.panelEx2.TabIndex = 5;
            this.panelEx2.Transparency = 100;
            // 
            // labelEx2
            // 
            this.labelEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEx2.BackColor = System.Drawing.Color.Transparent;
            this.labelEx2.BoundColor = System.Drawing.Color.Empty;
            this.labelEx2.ControlFace = System.Drawing.Color.White;
            this.labelEx2.CornerBottomLeft = 0;
            this.labelEx2.CornerBottomRight = 0;
            this.labelEx2.CornerTopLeft = 0;
            this.labelEx2.CornerTopRight = 0;
            this.labelEx2.ForeColor = System.Drawing.Color.Black;
            this.labelEx2.GlobalStyleEnable = false;
            this.labelEx2.GradientColor = System.Drawing.Color.Empty;
            this.labelEx2.Location = new System.Drawing.Point(2, 242);
            this.labelEx2.Margin = new System.Windows.Forms.Padding(0);
            this.labelEx2.Name = "labelEx2";
            this.labelEx2.Size = new System.Drawing.Size(245, 20);
            this.labelEx2.TabIndex = 19;
            this.labelEx2.Text = "姿态结果";
            this.labelEx2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEx2.Transparency = 200;
            // 
            // propertyGridEx2
            // 
            this.propertyGridEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridEx2.BackColor = System.Drawing.Color.Transparent;
            this.propertyGridEx2.ButtonBackColor = System.Drawing.Color.Gray;
            this.propertyGridEx2.ButtonBoundColor = System.Drawing.Color.Gray;
            this.propertyGridEx2.CategoryBackColor = System.Drawing.Color.White;
            this.propertyGridEx2.ControlFace = System.Drawing.Color.White;
            this.propertyGridEx2.DescribTransparency = 255;
            this.propertyGridEx2.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.propertyGridEx2.ForeColor = System.Drawing.Color.Black;
            this.propertyGridEx2.GlobalStyleEnable = false;
            this.propertyGridEx2.GradientColor = System.Drawing.Color.Empty;
            this.propertyGridEx2.ItemHeight = 20;
            this.propertyGridEx2.Location = new System.Drawing.Point(3, 262);
            this.propertyGridEx2.Margin = new System.Windows.Forms.Padding(0);
            this.propertyGridEx2.Name = "propertyGridEx2";
            this.propertyGridEx2.ScrollarBarColor = System.Drawing.Color.Silver;
            this.propertyGridEx2.Size = new System.Drawing.Size(245, 181);
            this.propertyGridEx2.TabIndex = 18;
            this.propertyGridEx2.Text = "propertyGridEx2";
            this.propertyGridEx2.Transparency = 100;
            // 
            // labelEx3
            // 
            this.labelEx3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEx3.BackColor = System.Drawing.Color.Transparent;
            this.labelEx3.BoundColor = System.Drawing.Color.Empty;
            this.labelEx3.ControlFace = System.Drawing.Color.White;
            this.labelEx3.CornerBottomLeft = 0;
            this.labelEx3.CornerBottomRight = 0;
            this.labelEx3.CornerTopLeft = 0;
            this.labelEx3.CornerTopRight = 0;
            this.labelEx3.ForeColor = System.Drawing.Color.Black;
            this.labelEx3.GlobalStyleEnable = false;
            this.labelEx3.GradientColor = System.Drawing.Color.Empty;
            this.labelEx3.Location = new System.Drawing.Point(3, 52);
            this.labelEx3.Margin = new System.Windows.Forms.Padding(0);
            this.labelEx3.Name = "labelEx3";
            this.labelEx3.Size = new System.Drawing.Size(245, 20);
            this.labelEx3.TabIndex = 14;
            this.labelEx3.Text = "项目配置";
            this.labelEx3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEx3.Transparency = 200;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEx1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxEx1.ButtonBackColor = System.Drawing.Color.White;
            this.comboBoxEx1.ButtonBoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxEx1.ButtonGradientColor = System.Drawing.Color.Empty;
            this.comboBoxEx1.ButtonTriangleColor = System.Drawing.Color.Black;
            this.comboBoxEx1.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxEx1.ControlFace = System.Drawing.Color.White;
            this.comboBoxEx1.CornerBottomLeft = 0;
            this.comboBoxEx1.CornerBottomRight = 0;
            this.comboBoxEx1.CornerTopLeft = 0;
            this.comboBoxEx1.CornerTopRight = 0;
            this.comboBoxEx1.DefaultText = null;
            this.comboBoxEx1.DefaultTextColor = System.Drawing.Color.Empty;
            this.comboBoxEx1.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.GlobalStyleEnable = false;
            this.comboBoxEx1.GradientColor = System.Drawing.Color.Empty;
            this.comboBoxEx1.Location = new System.Drawing.Point(3, 21);
            this.comboBoxEx1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxEx1.MaxShowDropDownItems = 8;
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.SelectedIndex = -1;
            this.comboBoxEx1.SelectedItem = null;
            this.comboBoxEx1.Size = new System.Drawing.Size(245, 21);
            this.comboBoxEx1.TabIndex = 15;
            this.comboBoxEx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.comboBoxEx1.Transparency = 100;
            this.comboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged);
            // 
            // propertyGridEx1
            // 
            this.propertyGridEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridEx1.BackColor = System.Drawing.Color.Transparent;
            this.propertyGridEx1.ButtonBackColor = System.Drawing.Color.Gray;
            this.propertyGridEx1.ButtonBoundColor = System.Drawing.Color.Gray;
            this.propertyGridEx1.CategoryBackColor = System.Drawing.Color.White;
            this.propertyGridEx1.ControlFace = System.Drawing.Color.White;
            this.propertyGridEx1.DescribTransparency = 255;
            this.propertyGridEx1.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.propertyGridEx1.ForeColor = System.Drawing.Color.Black;
            this.propertyGridEx1.GlobalStyleEnable = false;
            this.propertyGridEx1.GradientColor = System.Drawing.Color.Empty;
            this.propertyGridEx1.ItemHeight = 20;
            this.propertyGridEx1.Location = new System.Drawing.Point(3, 72);
            this.propertyGridEx1.Margin = new System.Windows.Forms.Padding(0);
            this.propertyGridEx1.Name = "propertyGridEx1";
            this.propertyGridEx1.ScrollarBarColor = System.Drawing.Color.Gray;
            this.propertyGridEx1.Size = new System.Drawing.Size(245, 121);
            this.propertyGridEx1.TabIndex = 13;
            this.propertyGridEx1.Text = "propertyGridEx1";
            this.propertyGridEx1.Transparency = 100;
            // 
            // buttonCalibPose
            // 
            this.buttonCalibPose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalibPose.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalibPose.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonCalibPose.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCalibPose.ControlFace = System.Drawing.Color.White;
            this.buttonCalibPose.CornerBottomLeft = 3;
            this.buttonCalibPose.CornerBottomRight = 3;
            this.buttonCalibPose.CornerTopLeft = 3;
            this.buttonCalibPose.CornerTopRight = 3;
            this.buttonCalibPose.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCalibPose.ForeColor = System.Drawing.Color.Black;
            this.buttonCalibPose.GlobalStyleEnable = false;
            this.buttonCalibPose.GradientColor = System.Drawing.Color.Empty;
            this.buttonCalibPose.Image = null;
            this.buttonCalibPose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonCalibPose.Location = new System.Drawing.Point(4, 207);
            this.buttonCalibPose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCalibPose.Name = "buttonCalibPose";
            this.buttonCalibPose.Size = new System.Drawing.Size(243, 25);
            this.buttonCalibPose.SpaceWidth = 0;
            this.buttonCalibPose.TabIndex = 16;
            this.buttonCalibPose.Text = "计算姿态";
            this.buttonCalibPose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonCalibPose.Transparency = 200;
            this.buttonCalibPose.Click += new System.EventHandler(this.buttonCalibPose_Click);
            // 
            // buttonSavePose
            // 
            this.buttonSavePose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePose.BackColor = System.Drawing.Color.Transparent;
            this.buttonSavePose.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonSavePose.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSavePose.ControlFace = System.Drawing.Color.White;
            this.buttonSavePose.CornerBottomLeft = 3;
            this.buttonSavePose.CornerBottomRight = 3;
            this.buttonSavePose.CornerTopLeft = 3;
            this.buttonSavePose.CornerTopRight = 3;
            this.buttonSavePose.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSavePose.ForeColor = System.Drawing.Color.Black;
            this.buttonSavePose.GlobalStyleEnable = false;
            this.buttonSavePose.GradientColor = System.Drawing.Color.Empty;
            this.buttonSavePose.Image = null;
            this.buttonSavePose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonSavePose.Location = new System.Drawing.Point(4, 457);
            this.buttonSavePose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSavePose.Name = "buttonSavePose";
            this.buttonSavePose.Size = new System.Drawing.Size(244, 25);
            this.buttonSavePose.SpaceWidth = 0;
            this.buttonSavePose.TabIndex = 17;
            this.buttonSavePose.Text = "保存姿态";
            this.buttonSavePose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSavePose.Transparency = 200;
            this.buttonSavePose.Click += new System.EventHandler(this.buttonSavePose_Click);
            // 
            // labelEx1
            // 
            this.labelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEx1.BackColor = System.Drawing.Color.Transparent;
            this.labelEx1.BoundColor = System.Drawing.Color.Empty;
            this.labelEx1.ControlFace = System.Drawing.Color.White;
            this.labelEx1.CornerBottomLeft = 0;
            this.labelEx1.CornerBottomRight = 0;
            this.labelEx1.CornerTopLeft = 0;
            this.labelEx1.CornerTopRight = 0;
            this.labelEx1.ForeColor = System.Drawing.Color.Black;
            this.labelEx1.GlobalStyleEnable = false;
            this.labelEx1.GradientColor = System.Drawing.Color.Empty;
            this.labelEx1.Location = new System.Drawing.Point(3, 2);
            this.labelEx1.Margin = new System.Windows.Forms.Padding(0);
            this.labelEx1.Name = "labelEx1";
            this.labelEx1.Size = new System.Drawing.Size(245, 20);
            this.labelEx1.TabIndex = 7;
            this.labelEx1.Text = "项目选择";
            this.labelEx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEx1.Transparency = 180;
            // 
            // panelEx4
            // 
            this.panelEx4.BackColor = System.Drawing.Color.Transparent;
            this.panelEx4.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelEx4.BoundStyle = ComponentLib.PanelEx.PanelDashStyle.Solid;
            this.panelEx4.ControlFace = System.Drawing.Color.White;
            this.panelEx4.Controls.Add(this.dataGridViewEx1);
            this.panelEx4.Controls.Add(this.labelEx5);
            this.panelEx4.CornerBottomLeft = 0;
            this.panelEx4.CornerBottomRight = 0;
            this.panelEx4.CornerTopLeft = 0;
            this.panelEx4.CornerTopRight = 0;
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx4.GlobalStyleEnable = false;
            this.panelEx4.GradientColor = System.Drawing.Color.Empty;
            this.panelEx4.Location = new System.Drawing.Point(0, 577);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(1160, 123);
            this.panelEx4.TabIndex = 23;
            this.panelEx4.Transparency = 100;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.BackImage = null;
            this.dataGridViewEx1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewEx1.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEx1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEx1.ColumnHeadersVisible = false;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewEx1.ControlBoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewEx1.ControlFace = System.Drawing.Color.White;
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewEx1.GlobalStyleEnable = false;
            this.dataGridViewEx1.GradientColor = System.Drawing.Color.Empty;
            this.dataGridViewEx1.GridBoundColor = System.Drawing.Color.Empty;
            this.dataGridViewEx1.HorScrollarAutoHide = true;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.ReadOnly = true;
            this.dataGridViewEx1.RowHeadersVisible = false;
            this.dataGridViewEx1.RowTemplate.Height = 15;
            this.dataGridViewEx1.Size = new System.Drawing.Size(1160, 99);
            this.dataGridViewEx1.TabIndex = 24;
            this.dataGridViewEx1.Transparency = 100;
            this.dataGridViewEx1.VerScrollarAutoHide = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "时间";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "日志信息";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // labelEx5
            // 
            this.labelEx5.BackColor = System.Drawing.Color.Transparent;
            this.labelEx5.BoundColor = System.Drawing.Color.Empty;
            this.labelEx5.ControlFace = System.Drawing.Color.White;
            this.labelEx5.CornerBottomLeft = 0;
            this.labelEx5.CornerBottomRight = 0;
            this.labelEx5.CornerTopLeft = 0;
            this.labelEx5.CornerTopRight = 0;
            this.labelEx5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEx5.ForeColor = System.Drawing.Color.Black;
            this.labelEx5.GlobalStyleEnable = false;
            this.labelEx5.GradientColor = System.Drawing.Color.Empty;
            this.labelEx5.Location = new System.Drawing.Point(0, 0);
            this.labelEx5.Margin = new System.Windows.Forms.Padding(0);
            this.labelEx5.Name = "labelEx5";
            this.labelEx5.Size = new System.Drawing.Size(1160, 24);
            this.labelEx5.TabIndex = 23;
            this.labelEx5.Text = "运行日志";
            this.labelEx5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEx5.Transparency = 100;
            // 
            // panelEx5
            // 
            this.panelEx5.BackColor = System.Drawing.Color.Transparent;
            this.panelEx5.BoundColor = System.Drawing.Color.Empty;
            this.panelEx5.BoundStyle = ComponentLib.PanelEx.PanelDashStyle.Solid;
            this.panelEx5.ControlFace = System.Drawing.Color.White;
            this.panelEx5.Controls.Add(this.segmentLine3);
            this.panelEx5.Controls.Add(this.btn_Down_view);
            this.panelEx5.Controls.Add(this.btn_Up_view);
            this.panelEx5.Controls.Add(this.btn_Right_view);
            this.panelEx5.Controls.Add(this.btn_Left_view);
            this.panelEx5.Controls.Add(this.btn_Back_view);
            this.panelEx5.Controls.Add(this.btn_Front_view);
            this.panelEx5.Controls.Add(this.segmentLine2);
            this.panelEx5.Controls.Add(this.btn_saveas_config);
            this.panelEx5.Controls.Add(this.btn_save_config);
            this.panelEx5.Controls.Add(this.btn_load_config);
            this.panelEx5.Controls.Add(this.segmentLine1);
            this.panelEx5.CornerBottomLeft = 0;
            this.panelEx5.CornerBottomRight = 0;
            this.panelEx5.CornerTopLeft = 0;
            this.panelEx5.CornerTopRight = 0;
            this.panelEx5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx5.GlobalStyleEnable = false;
            this.panelEx5.GradientColor = System.Drawing.Color.Empty;
            this.panelEx5.Location = new System.Drawing.Point(0, 55);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(1160, 25);
            this.panelEx5.TabIndex = 24;
            this.panelEx5.Transparency = 100;
            // 
            // segmentLine3
            // 
            this.segmentLine3.ControlFace = System.Drawing.Color.White;
            this.segmentLine3.Dock = System.Windows.Forms.DockStyle.Left;
            this.segmentLine3.GlobalStyleEnable = false;
            this.segmentLine3.GradientColor = System.Drawing.Color.Empty;
            this.segmentLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.segmentLine3.LineWidth = 1;
            this.segmentLine3.Location = new System.Drawing.Point(245, 0);
            this.segmentLine3.Name = "segmentLine3";
            this.segmentLine3.Orientation = ComponentLib.SegmentLine.OrientationType.Vertical;
            this.segmentLine3.Size = new System.Drawing.Size(10, 25);
            this.segmentLine3.TabIndex = 11;
            this.segmentLine3.Text = "segmentLine3";
            this.segmentLine3.Transparency = 100;
            // 
            // btn_Down_view
            // 
            this.btn_Down_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_Down_view.BoundColor = System.Drawing.Color.Empty;
            this.btn_Down_view.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Down_view.ControlFace = System.Drawing.Color.White;
            this.btn_Down_view.CornerBottomLeft = 0;
            this.btn_Down_view.CornerBottomRight = 0;
            this.btn_Down_view.CornerTopLeft = 0;
            this.btn_Down_view.CornerTopRight = 0;
            this.btn_Down_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Down_view.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Down_view.ForeColor = System.Drawing.Color.Black;
            this.btn_Down_view.GlobalStyleEnable = false;
            this.btn_Down_view.GradientColor = System.Drawing.Color.Empty;
            this.btn_Down_view.Image = global::SensorPoseCalibration.Properties.Resources.down;
            this.btn_Down_view.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Down_view.Location = new System.Drawing.Point(220, 0);
            this.btn_Down_view.Name = "btn_Down_view";
            this.btn_Down_view.Size = new System.Drawing.Size(25, 25);
            this.btn_Down_view.SpaceWidth = 0;
            this.btn_Down_view.TabIndex = 10;
            this.btn_Down_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Down_view.Transparency = 100;
            this.btn_Down_view.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Up_view
            // 
            this.btn_Up_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_Up_view.BoundColor = System.Drawing.Color.Empty;
            this.btn_Up_view.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Up_view.ControlFace = System.Drawing.Color.White;
            this.btn_Up_view.CornerBottomLeft = 0;
            this.btn_Up_view.CornerBottomRight = 0;
            this.btn_Up_view.CornerTopLeft = 0;
            this.btn_Up_view.CornerTopRight = 0;
            this.btn_Up_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Up_view.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Up_view.ForeColor = System.Drawing.Color.Black;
            this.btn_Up_view.GlobalStyleEnable = false;
            this.btn_Up_view.GradientColor = System.Drawing.Color.Empty;
            this.btn_Up_view.Image = global::SensorPoseCalibration.Properties.Resources.up;
            this.btn_Up_view.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Up_view.Location = new System.Drawing.Point(195, 0);
            this.btn_Up_view.Name = "btn_Up_view";
            this.btn_Up_view.Size = new System.Drawing.Size(25, 25);
            this.btn_Up_view.SpaceWidth = 0;
            this.btn_Up_view.TabIndex = 9;
            this.btn_Up_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Up_view.Transparency = 100;
            this.btn_Up_view.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Right_view
            // 
            this.btn_Right_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_Right_view.BoundColor = System.Drawing.Color.Empty;
            this.btn_Right_view.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Right_view.ControlFace = System.Drawing.Color.White;
            this.btn_Right_view.CornerBottomLeft = 0;
            this.btn_Right_view.CornerBottomRight = 0;
            this.btn_Right_view.CornerTopLeft = 0;
            this.btn_Right_view.CornerTopRight = 0;
            this.btn_Right_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Right_view.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Right_view.ForeColor = System.Drawing.Color.Black;
            this.btn_Right_view.GlobalStyleEnable = false;
            this.btn_Right_view.GradientColor = System.Drawing.Color.Empty;
            this.btn_Right_view.Image = global::SensorPoseCalibration.Properties.Resources.right;
            this.btn_Right_view.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Right_view.Location = new System.Drawing.Point(170, 0);
            this.btn_Right_view.Name = "btn_Right_view";
            this.btn_Right_view.Size = new System.Drawing.Size(25, 25);
            this.btn_Right_view.SpaceWidth = 0;
            this.btn_Right_view.TabIndex = 8;
            this.btn_Right_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Right_view.Transparency = 100;
            this.btn_Right_view.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Left_view
            // 
            this.btn_Left_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_Left_view.BoundColor = System.Drawing.Color.Empty;
            this.btn_Left_view.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Left_view.ControlFace = System.Drawing.Color.White;
            this.btn_Left_view.CornerBottomLeft = 0;
            this.btn_Left_view.CornerBottomRight = 0;
            this.btn_Left_view.CornerTopLeft = 0;
            this.btn_Left_view.CornerTopRight = 0;
            this.btn_Left_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Left_view.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Left_view.ForeColor = System.Drawing.Color.Black;
            this.btn_Left_view.GlobalStyleEnable = false;
            this.btn_Left_view.GradientColor = System.Drawing.Color.Empty;
            this.btn_Left_view.Image = global::SensorPoseCalibration.Properties.Resources.left;
            this.btn_Left_view.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Left_view.Location = new System.Drawing.Point(145, 0);
            this.btn_Left_view.Name = "btn_Left_view";
            this.btn_Left_view.Size = new System.Drawing.Size(25, 25);
            this.btn_Left_view.SpaceWidth = 0;
            this.btn_Left_view.TabIndex = 7;
            this.btn_Left_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Left_view.Transparency = 100;
            this.btn_Left_view.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Back_view
            // 
            this.btn_Back_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back_view.BoundColor = System.Drawing.Color.Empty;
            this.btn_Back_view.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Back_view.ControlFace = System.Drawing.Color.White;
            this.btn_Back_view.CornerBottomLeft = 0;
            this.btn_Back_view.CornerBottomRight = 0;
            this.btn_Back_view.CornerTopLeft = 0;
            this.btn_Back_view.CornerTopRight = 0;
            this.btn_Back_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Back_view.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Back_view.ForeColor = System.Drawing.Color.Black;
            this.btn_Back_view.GlobalStyleEnable = false;
            this.btn_Back_view.GradientColor = System.Drawing.Color.Empty;
            this.btn_Back_view.Image = global::SensorPoseCalibration.Properties.Resources.back;
            this.btn_Back_view.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Back_view.Location = new System.Drawing.Point(120, 0);
            this.btn_Back_view.Name = "btn_Back_view";
            this.btn_Back_view.Size = new System.Drawing.Size(25, 25);
            this.btn_Back_view.SpaceWidth = 0;
            this.btn_Back_view.TabIndex = 6;
            this.btn_Back_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Back_view.Transparency = 100;
            this.btn_Back_view.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Front_view
            // 
            this.btn_Front_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_Front_view.BoundColor = System.Drawing.Color.Empty;
            this.btn_Front_view.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Front_view.ControlFace = System.Drawing.Color.White;
            this.btn_Front_view.CornerBottomLeft = 0;
            this.btn_Front_view.CornerBottomRight = 0;
            this.btn_Front_view.CornerTopLeft = 0;
            this.btn_Front_view.CornerTopRight = 0;
            this.btn_Front_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Front_view.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Front_view.ForeColor = System.Drawing.Color.Black;
            this.btn_Front_view.GlobalStyleEnable = false;
            this.btn_Front_view.GradientColor = System.Drawing.Color.Empty;
            this.btn_Front_view.Image = global::SensorPoseCalibration.Properties.Resources.front;
            this.btn_Front_view.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Front_view.Location = new System.Drawing.Point(95, 0);
            this.btn_Front_view.Name = "btn_Front_view";
            this.btn_Front_view.Size = new System.Drawing.Size(25, 25);
            this.btn_Front_view.SpaceWidth = 0;
            this.btn_Front_view.TabIndex = 5;
            this.btn_Front_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Front_view.Transparency = 100;
            this.btn_Front_view.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // segmentLine2
            // 
            this.segmentLine2.ControlFace = System.Drawing.Color.White;
            this.segmentLine2.Dock = System.Windows.Forms.DockStyle.Left;
            this.segmentLine2.GlobalStyleEnable = false;
            this.segmentLine2.GradientColor = System.Drawing.Color.Empty;
            this.segmentLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.segmentLine2.LineWidth = 1;
            this.segmentLine2.Location = new System.Drawing.Point(85, 0);
            this.segmentLine2.Name = "segmentLine2";
            this.segmentLine2.Orientation = ComponentLib.SegmentLine.OrientationType.Vertical;
            this.segmentLine2.Size = new System.Drawing.Size(10, 25);
            this.segmentLine2.TabIndex = 4;
            this.segmentLine2.Text = "segmentLine2";
            this.segmentLine2.Transparency = 100;
            // 
            // btn_saveas_config
            // 
            this.btn_saveas_config.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveas_config.BoundColor = System.Drawing.Color.Empty;
            this.btn_saveas_config.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_saveas_config.ControlFace = System.Drawing.Color.White;
            this.btn_saveas_config.CornerBottomLeft = 0;
            this.btn_saveas_config.CornerBottomRight = 0;
            this.btn_saveas_config.CornerTopLeft = 0;
            this.btn_saveas_config.CornerTopRight = 0;
            this.btn_saveas_config.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_saveas_config.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_saveas_config.ForeColor = System.Drawing.Color.Black;
            this.btn_saveas_config.GlobalStyleEnable = false;
            this.btn_saveas_config.GradientColor = System.Drawing.Color.Empty;
            this.btn_saveas_config.Image = global::SensorPoseCalibration.Properties.Resources.saveas;
            this.btn_saveas_config.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_saveas_config.Location = new System.Drawing.Point(60, 0);
            this.btn_saveas_config.Name = "btn_saveas_config";
            this.btn_saveas_config.Size = new System.Drawing.Size(25, 25);
            this.btn_saveas_config.SpaceWidth = 0;
            this.btn_saveas_config.TabIndex = 3;
            this.btn_saveas_config.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_saveas_config.Transparency = 100;
            this.btn_saveas_config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // btn_save_config
            // 
            this.btn_save_config.BackColor = System.Drawing.Color.Transparent;
            this.btn_save_config.BoundColor = System.Drawing.Color.Empty;
            this.btn_save_config.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_save_config.ControlFace = System.Drawing.Color.White;
            this.btn_save_config.CornerBottomLeft = 0;
            this.btn_save_config.CornerBottomRight = 0;
            this.btn_save_config.CornerTopLeft = 0;
            this.btn_save_config.CornerTopRight = 0;
            this.btn_save_config.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_save_config.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_save_config.ForeColor = System.Drawing.Color.Black;
            this.btn_save_config.GlobalStyleEnable = false;
            this.btn_save_config.GradientColor = System.Drawing.Color.Empty;
            this.btn_save_config.Image = global::SensorPoseCalibration.Properties.Resources.save_1;
            this.btn_save_config.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_save_config.Location = new System.Drawing.Point(35, 0);
            this.btn_save_config.Name = "btn_save_config";
            this.btn_save_config.Size = new System.Drawing.Size(25, 25);
            this.btn_save_config.SpaceWidth = 0;
            this.btn_save_config.TabIndex = 2;
            this.btn_save_config.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_save_config.Transparency = 100;
            this.btn_save_config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // btn_load_config
            // 
            this.btn_load_config.BackColor = System.Drawing.Color.Transparent;
            this.btn_load_config.BoundColor = System.Drawing.Color.Empty;
            this.btn_load_config.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_load_config.ControlFace = System.Drawing.Color.White;
            this.btn_load_config.CornerBottomLeft = 0;
            this.btn_load_config.CornerBottomRight = 0;
            this.btn_load_config.CornerTopLeft = 0;
            this.btn_load_config.CornerTopRight = 0;
            this.btn_load_config.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_load_config.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_load_config.ForeColor = System.Drawing.Color.Black;
            this.btn_load_config.GlobalStyleEnable = false;
            this.btn_load_config.GradientColor = System.Drawing.Color.Empty;
            this.btn_load_config.Image = global::SensorPoseCalibration.Properties.Resources.open;
            this.btn_load_config.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_load_config.Location = new System.Drawing.Point(10, 0);
            this.btn_load_config.Name = "btn_load_config";
            this.btn_load_config.Size = new System.Drawing.Size(25, 25);
            this.btn_load_config.SpaceWidth = 0;
            this.btn_load_config.TabIndex = 1;
            this.btn_load_config.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_load_config.Transparency = 100;
            this.btn_load_config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // segmentLine1
            // 
            this.segmentLine1.ControlFace = System.Drawing.Color.White;
            this.segmentLine1.Dock = System.Windows.Forms.DockStyle.Left;
            this.segmentLine1.GlobalStyleEnable = false;
            this.segmentLine1.GradientColor = System.Drawing.Color.Empty;
            this.segmentLine1.LineColor = System.Drawing.Color.Empty;
            this.segmentLine1.LineWidth = 1;
            this.segmentLine1.Location = new System.Drawing.Point(0, 0);
            this.segmentLine1.Name = "segmentLine1";
            this.segmentLine1.Orientation = ComponentLib.SegmentLine.OrientationType.Vertical;
            this.segmentLine1.Size = new System.Drawing.Size(10, 25);
            this.segmentLine1.TabIndex = 0;
            this.segmentLine1.Text = "segmentLine1";
            this.segmentLine1.Transparency = 100;
            // 
            // menuStripEx1
            // 
            this.menuStripEx1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStripEx1.BackColor = System.Drawing.Color.White;
            this.menuStripEx1.ControlFace = System.Drawing.Color.White;
            this.menuStripEx1.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStripEx1.ForeColor = System.Drawing.Color.Black;
            this.menuStripEx1.GlobalStyleEnable = false;
            this.menuStripEx1.GradientColor = System.Drawing.Color.Empty;
            this.menuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.运行RToolStripMenuItem,
            this.视图VToolStripMenuItem,
            this.项目管理MToolStripMenuItem});
            this.menuStripEx1.Location = new System.Drawing.Point(0, 30);
            this.menuStripEx1.Name = "menuStripEx1";
            this.menuStripEx1.Size = new System.Drawing.Size(1160, 25);
            this.menuStripEx1.TabIndex = 9;
            this.menuStripEx1.Text = "menuStripEx1";
            this.menuStripEx1.Transparency = 100;
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载配置ToolStripMenuItem,
            this.保存配置ToolStripMenuItem,
            this.另存为ToolStripMenuItem});
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
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.另存为ToolStripMenuItem.Text = "另存配置";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
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
            this.计算姿态ToolStripMenuItem.Click += new System.EventHandler(this.计算姿态ToolStripMenuItem_Click);
            // 
            // 保存结果ToolStripMenuItem
            // 
            this.保存结果ToolStripMenuItem.Name = "保存结果ToolStripMenuItem";
            this.保存结果ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存结果ToolStripMenuItem.Text = "保存结果";
            this.保存结果ToolStripMenuItem.Click += new System.EventHandler(this.保存结果ToolStripMenuItem_Click);
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFront,
            this.ToolStripMenuItemBack,
            this.ToolStripMenuItemLeft,
            this.ToolStripMenuItemRight,
            this.ToolStripMenuItemTop,
            this.ToolStripMenuItemBottom});
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // ToolStripMenuItemFront
            // 
            this.ToolStripMenuItemFront.Name = "ToolStripMenuItemFront";
            this.ToolStripMenuItemFront.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemFront.Text = "前视图";
            this.ToolStripMenuItemFront.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemBack
            // 
            this.ToolStripMenuItemBack.Name = "ToolStripMenuItemBack";
            this.ToolStripMenuItemBack.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemBack.Text = "后视图";
            this.ToolStripMenuItemBack.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemLeft
            // 
            this.ToolStripMenuItemLeft.Name = "ToolStripMenuItemLeft";
            this.ToolStripMenuItemLeft.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemLeft.Text = "左视图";
            this.ToolStripMenuItemLeft.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemRight
            // 
            this.ToolStripMenuItemRight.Name = "ToolStripMenuItemRight";
            this.ToolStripMenuItemRight.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemRight.Text = "右视图";
            this.ToolStripMenuItemRight.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemTop
            // 
            this.ToolStripMenuItemTop.Name = "ToolStripMenuItemTop";
            this.ToolStripMenuItemTop.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemTop.Text = "俯视图";
            this.ToolStripMenuItemTop.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemBottom
            // 
            this.ToolStripMenuItemBottom.Name = "ToolStripMenuItemBottom";
            this.ToolStripMenuItemBottom.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemBottom.Text = "仰视图";
            this.ToolStripMenuItemBottom.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
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
            this.title1.BackColor = System.Drawing.Color.Transparent;
            this.title1.BoundColor = System.Drawing.Color.Empty;
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
            this.title1.Size = new System.Drawing.Size(1160, 30);
            this.title1.TabIndex = 0;
            this.title1.Text = "Sensor Pose Calibration";
            this.title1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.title1.TitleHeight = 30;
            this.title1.Transparency = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 700);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.panelEx5.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem 项目管理MToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private ComponentLib.PanelEx panelEx3;
        private ComponentLib.LabelEx labelEx4;
        private ComponentLib.PropertyGridEx propertyGridEx3;
        private UserControls.Map3D map3D1;
        private ComponentLib.PanelEx panelEx4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFront;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private ComponentLib.PanelEx panelEx5;
        private ComponentLib.ButtonEx btn_Down_view;
        private ComponentLib.ButtonEx btn_Up_view;
        private ComponentLib.ButtonEx btn_Right_view;
        private ComponentLib.ButtonEx btn_Left_view;
        private ComponentLib.ButtonEx btn_Back_view;
        private ComponentLib.ButtonEx btn_Front_view;
        private ComponentLib.SegmentLine segmentLine2;
        private ComponentLib.ButtonEx btn_saveas_config;
        private ComponentLib.ButtonEx btn_save_config;
        private ComponentLib.ButtonEx btn_load_config;
        private ComponentLib.SegmentLine segmentLine1;
        private ComponentLib.SegmentLine segmentLine3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBack;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLeft;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRight;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTop;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBottom;
        private ComponentLib.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private ComponentLib.LabelEx labelEx5;
    }
}