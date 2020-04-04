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
    public partial class Loading : Form
    {
        MainForm ownerForm;
        public Loading(MainForm owner)
        {
            ownerForm = owner;
            ownerForm.isLoadingDone = false;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarEx1.Value += 0.1;
            if (progressBarEx1.Value == 1)
                progressBarEx1.Value = 0;
            if(ownerForm.isLoadingDone)
            {
                timer1.Stop();
                this.Dispose();
            }
        }
    }
}
