using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorPoseCalibration
{
    public partial class Loading : Form
    {
        const int WM_COPYDATA = 0x004A;
        public Loading(MainForm owner)
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBarEx1.Value += 0.1;
            //if (progressBarEx1.Value == 1)
            //    progressBarEx1.Value = 0;
            if(MainForm.isLoadingDone)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_COPYDATA)
            {
                COPYDATASTRUCT curInfo = (COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));
                try
                {
                    progressBarEx1.Value = Convert.ToDouble(curInfo.lpData);
                }
                catch(Exception) { }
            }
        }
    }
}
