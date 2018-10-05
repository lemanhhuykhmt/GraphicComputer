using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TongHop.UC.Lines;

namespace TongHop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tvSelectProject_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Name.Equals("nDDA"))
            {
                pnlWindows.Controls.Clear();
                ucDDA frm = new ucDDA();
                frm.Size = new Size(pnlWindows.Width, pnlWindows.Height);
                frm.Visible = true;
                pnlWindows.Controls.Add(frm);
            }
            else if (e.Node.Name.Equals("nBresenham"))
            {
                pnlWindows.Controls.Clear();
                ucBresenham frm = new ucBresenham();
                frm.Size = new Size(pnlWindows.Width, pnlWindows.Height);
                frm.Visible = true;
                pnlWindows.Controls.Add(frm);
            }
        }
    }
}
