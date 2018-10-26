using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(e.Node.Name.Equals("nLines"))
            {
                pnlWindows.Controls.Clear();
                UC.Lines.ucLines frm = new UC.Lines.ucLines();
                frm.Size = new Size(pnlWindows.Width, pnlWindows.Height);
                frm.Visible = true;
                pnlWindows.Controls.Add(frm);
            }
            else if (e.Node.Name.Equals("nCircle"))
            {
                pnlWindows.Controls.Clear();
                UC.Circle.ucCircle frm = new UC.Circle.ucCircle();
                frm.Size = new Size(pnlWindows.Width, pnlWindows.Height);
                frm.Visible = true;
                pnlWindows.Controls.Add(frm);
            }
            else if (e.Node.Name.Equals("nCircleMove"))
            {
                pnlWindows.Controls.Clear();
                UC.CircleMove.CircleMove frm = new UC.CircleMove.CircleMove();
                frm.Size = new Size(pnlWindows.Width, pnlWindows.Height);
                frm.Visible = true;
                pnlWindows.Controls.Add(frm);
            }
            else if (e.Node.Name.Equals("nRectangle"))
            {
                pnlWindows.Controls.Clear();
                UC.Rectangle.ucRectangleMove frm = new UC.Rectangle.ucRectangleMove();
                frm.Size = new Size(pnlWindows.Width, pnlWindows.Height);
                frm.Visible = true;
                pnlWindows.Controls.Add(frm);
            }
            else if (e.Node.Name.Equals("nWheelMove"))
            {
                pnlWindows.Controls.Clear();
                UC.Wheel.ucWheelMove frm = new UC.Wheel.ucWheelMove();
                frm.Size = new Size(pnlWindows.Width, pnlWindows.Height);
                frm.Visible = true;
                pnlWindows.Controls.Add(frm);
            }
            else if (e.Node.Name.Equals("nRGB"))
            {
                pnlWindows.Controls.Clear();
                UC.RBG.ucRBG frm = new UC.RBG.ucRBG();
                frm.Size = new Size(pnlWindows.Width, pnlWindows.Height);
                frm.Visible = true;
                pnlWindows.Controls.Add(frm);
            }
        }
    }
}
