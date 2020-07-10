namespace SensorPoseCalibration
{
    partial class ResultCenterRadiusShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultCenterRadiusShow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new ComponentLib.PanelEx();
            this.dataGridViewEx1 = new ComponentLib.DataGridViewEx();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title1 = new ComponentLib.Title();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.BackColor = System.Drawing.Color.Transparent;
            this.panelEx1.BoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx1.BoundStyle = ComponentLib.PanelEx.PanelDashStyle.Solid;
            this.panelEx1.ControlFace = System.Drawing.Color.White;
            this.panelEx1.Controls.Add(this.dataGridViewEx1);
            this.panelEx1.Controls.Add(this.title1);
            this.panelEx1.CornerBottomLeft = 0;
            this.panelEx1.CornerBottomRight = 0;
            this.panelEx1.CornerTopLeft = 0;
            this.panelEx1.CornerTopRight = 0;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.GlobalStyleEnable = false;
            this.panelEx1.GradientColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(376, 152);
            this.panelEx1.TabIndex = 2;
            this.panelEx1.Transparency = 100;
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToDeleteRows = false;
            this.dataGridViewEx1.BackImage = ((System.Drawing.Image)(resources.GetObject("dataGridViewEx1.BackImage")));
            this.dataGridViewEx1.BoundColor = System.Drawing.Color.Gray;
            this.dataGridViewEx1.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEx1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEx1.ColumnHeadersHeight = 18;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewEx1.ControlBoundColor = System.Drawing.Color.Gray;
            this.dataGridViewEx1.ControlFace = System.Drawing.Color.White;
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewEx1.GlobalStyleEnable = false;
            this.dataGridViewEx1.GradientColor = System.Drawing.Color.Empty;
            this.dataGridViewEx1.GridBoundColor = System.Drawing.Color.Gray;
            this.dataGridViewEx1.HorScrollarAutoHide = true;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.RowHeadersVisible = false;
            this.dataGridViewEx1.RowTemplate.Height = 18;
            this.dataGridViewEx1.Size = new System.Drawing.Size(376, 128);
            this.dataGridViewEx1.TabIndex = 1;
            this.dataGridViewEx1.Transparency = 100;
            this.dataGridViewEx1.VerScrollarAutoHide = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "点云";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "球心";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "半径";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.title1.Size = new System.Drawing.Size(376, 24);
            this.title1.TabIndex = 0;
            this.title1.Text = "Result Center/Radius ";
            this.title1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.title1.TitleHeight = 25;
            this.title1.Transparency = 100;
            // 
            // ResultCenterRadiusShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 152);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultCenterRadiusShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultCenterRadiusShow";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentLib.PanelEx panelEx1;
        private ComponentLib.Title title1;
        private ComponentLib.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}