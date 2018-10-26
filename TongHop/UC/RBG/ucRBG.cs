using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongHop.UC.RBG
{
    public partial class ucRBG : UserControl
    {
        public ucRBG()
        {
            InitializeComponent();
        }
      

        private void trbRed_Scroll(object sender, EventArgs e)
        {
            loadValueColor();
        }

        private void trbGreen_Scroll(object sender, EventArgs e)
        {
            loadValueColor();
        }

        private void trbBlue_Scroll(object sender, EventArgs e)
        {
            loadValueColor();
        }
        private void loadValueColor()
        {
            pnlColor.BackColor = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);
            pnlValueRed.BackColor = Color.FromArgb(trbRed.Value, 0, 0);
            pnlValueGreen.BackColor = Color.FromArgb(0, trbGreen.Value, 0);
            pnlValueBlue.BackColor = Color.FromArgb(0, 0, trbBlue.Value);

            lbValueRed.Text = "" + trbRed.Value;
            lbValueGreen.Text = "" + trbGreen.Value;
            lbValueBlue.Text = "" + trbBlue.Value;
        }

        //private void RGB2CMY()
        //{
        //    double dr = (double)trbRed.Value / 255;
        //    double dg = (double)trbGreen.Value / 255;
        //    double db = (double)trbBlue.Value / 255;
        //    double k = 1 - Math.Max(Math.Max(dr, dg), db);
        //    if(k == 1)
        //    {
        //        tbC.Value = tbM.Value = tbY.Value = 0;
        //        return;
        //    }
        //    tbC.Value = DEFINE.Round((1.0 - dr - k) / (1 - k) * 255) ;
        //    tbM.Value = DEFINE.Round((1.0 - dg - k) / (1 - k) * 255);
        //    tbY.Value = DEFINE.Round((1.0 - db - k) / (1 - k) * 255);
        //}

        //private void CMY2RGB()
        //{
        //    trbRed.Value = 255 * (1 - DEFINE.Round(tbC.Value / 255));
        //    trbGreen.Value = 255 * (1 - DEFINE.Round(tbM.Value / 255));
        //    trbBlue.Value = 255 * (1 - DEFINE.Round(tbY.Value / 255)) ;
        //}
    }
}
