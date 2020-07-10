namespace SensorPoseCalibration
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarEx1 = new ComponentLib.ProgressBarEx();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarEx1
            // 
            this.progressBarEx1.BackColor = System.Drawing.Color.Transparent;
            this.progressBarEx1.BackImage = ((System.Drawing.Image)(resources.GetObject("progressBarEx1.BackImage")));
            this.progressBarEx1.ControlFace = System.Drawing.Color.White;
            this.progressBarEx1.DataBackColor = System.Drawing.Color.Silver;
            this.progressBarEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarEx1.Font = new System.Drawing.Font("Times New Roman", 6F);
            this.progressBarEx1.ForeColor = System.Drawing.Color.Black;
            this.progressBarEx1.GlobalStyleEnable = false;
            this.progressBarEx1.GradientColor = System.Drawing.Color.Empty;
            this.progressBarEx1.LineWidth = 15F;
            this.progressBarEx1.Location = new System.Drawing.Point(0, 0);
            this.progressBarEx1.Name = "progressBarEx1";
            this.progressBarEx1.ShowValue = true;
            this.progressBarEx1.Size = new System.Drawing.Size(106, 161);
            this.progressBarEx1.Style = ComponentLib.ProgressBarEx.ProgressStyle.Circle;
            this.progressBarEx1.TabIndex = 1;
            this.progressBarEx1.Transparency = 0;
            this.progressBarEx1.Value = 0D;
            this.progressBarEx1.ValueBackColor = System.Drawing.Color.LightSkyBlue;
            // 
            // Loading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(106, 161);
            this.Controls.Add(this.progressBarEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ComponentLib.ProgressBarEx progressBarEx1;
    }
}