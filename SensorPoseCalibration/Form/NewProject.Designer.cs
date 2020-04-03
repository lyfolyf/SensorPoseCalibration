namespace SensorPoseCalibration
{
    partial class NewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            ComponentLib.ButtonEx.ShapeParam shapeParam1 = new ComponentLib.ButtonEx.ShapeParam();
            ComponentLib.ButtonEx.ShapeParam shapeParam2 = new ComponentLib.ButtonEx.ShapeParam();
            this.panelEx1 = new ComponentLib.PanelEx();
            this.textBoxProjectName = new ComponentLib.TextBoxEx();
            this.buttonCancel = new ComponentLib.ButtonEx();
            this.buttonOK = new ComponentLib.ButtonEx();
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
            this.panelEx1.Controls.Add(this.textBoxProjectName);
            this.panelEx1.Controls.Add(this.buttonCancel);
            this.panelEx1.Controls.Add(this.buttonOK);
            this.panelEx1.Controls.Add(this.title1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.GlobalStyleEnable = false;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(356, 56);
            this.panelEx1.TabIndex = 1;
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.BackImage = null;
            this.textBoxProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProjectName.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxProjectName.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxProjectName.GlobalStyleEnable = false;
            this.textBoxProjectName.Location = new System.Drawing.Point(3, 28);
            this.textBoxProjectName.MouseOverColorEnable = true;
            this.textBoxProjectName.MultiLineCount = 10;
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(194, 21);
            this.textBoxProjectName.TabIndex = 27;
            this.textBoxProjectName.TextChanged += new System.EventHandler(this.textBoxProjectName_TextChanged);
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
            this.buttonCancel.Location = new System.Drawing.Point(280, 27);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            shapeParam1.bottomLeft = 2;
            shapeParam1.bottomRight = 2;
            shapeParam1.clientHeight = 25;
            shapeParam1.clientWidth = 63;
            shapeParam1.topLeft = 2;
            shapeParam1.topRight = 2;
            shapeParam1.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonCancel.Shape = shapeParam1;
            this.buttonCancel.Size = new System.Drawing.Size(63, 25);
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
            this.buttonOK.Location = new System.Drawing.Point(204, 27);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOK.Name = "buttonOK";
            shapeParam2.bottomLeft = 2;
            shapeParam2.bottomRight = 2;
            shapeParam2.clientHeight = 25;
            shapeParam2.clientWidth = 64;
            shapeParam2.topLeft = 2;
            shapeParam2.topRight = 2;
            shapeParam2.type = ComponentLib.ButtonEx.ShapeType.Default;
            this.buttonOK.Shape = shapeParam2;
            this.buttonOK.Size = new System.Drawing.Size(64, 25);
            this.buttonOK.TabIndex = 25;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
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
            this.title1.Text = "New Project";
            this.title1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.title1.TitleHeight = 20;
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 56);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProject";
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentLib.PanelEx panelEx1;
        private ComponentLib.TextBoxEx textBoxProjectName;
        private ComponentLib.ButtonEx buttonCancel;
        private ComponentLib.ButtonEx buttonOK;
        private ComponentLib.Title title1;
    }
}