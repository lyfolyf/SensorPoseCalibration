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
    public partial class ResultCenterRadiusShow : Form
    {
        public ResultCenterRadius resultCenterRadius;
        public ResultCenterRadiusShow(ResultCenterRadius param)
        {
            resultCenterRadius = param;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach(var item in resultCenterRadius.CenterRadiusLst)
            {
                int index = dataGridViewEx1.Rows.Add();
                dataGridViewEx1.Rows[index].Cells[0].Value = "点云" + resultCenterRadius.CenterRadiusLst.FindIndex(p=>p==item);
                dataGridViewEx1.Rows[index].Cells[1].Value = "(" + item.Item1.X.ToString("0.0000") + "," + item.Item1.Y.ToString("0.0000") + "," + item.Item1.Z.ToString("0.0000") + ")";
                dataGridViewEx1.Rows[index].Cells[2].Value = item.Item2.ToString("0.0000");
            }
        }
    }
}
