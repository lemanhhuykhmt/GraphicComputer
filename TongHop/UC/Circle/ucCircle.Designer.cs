namespace TongHop.UC.Circle
{
    partial class ucCircle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbElip = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbA = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rbElip = new System.Windows.Forms.RadioButton();
            this.rbToaDoCuc = new System.Windows.Forms.RadioButton();
            this.rbMidpoint = new System.Windows.Forms.RadioButton();
            this.rbDecac = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRadius = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbRadius = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.gbCenter = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbElip.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRadius.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadius)).BeginInit();
            this.gbCenter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElip
            // 
            this.gbElip.Controls.Add(this.panel10);
            this.gbElip.Controls.Add(this.panel4);
            this.gbElip.Location = new System.Drawing.Point(242, 16);
            this.gbElip.Margin = new System.Windows.Forms.Padding(4);
            this.gbElip.Name = "gbElip";
            this.gbElip.Padding = new System.Windows.Forms.Padding(4);
            this.gbElip.Size = new System.Drawing.Size(300, 100);
            this.gbElip.TabIndex = 4;
            this.gbElip.TabStop = false;
            this.gbElip.Text = "Radius Elip";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(14, 54);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(282, 33);
            this.panel10.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbB);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(34, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(248, 33);
            this.panel11.TabIndex = 1;
            // 
            // tbB
            // 
            this.tbB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbB.Location = new System.Drawing.Point(49, 0);
            this.tbB.Maximum = 300;
            this.tbB.Minimum = 10;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(150, 33);
            this.tbB.TabIndex = 2;
            this.tbB.Value = 10;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(199, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "300";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "B:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(11, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 33);
            this.panel4.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbA);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(37, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 33);
            this.panel6.TabIndex = 1;
            // 
            // tbA
            // 
            this.tbA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbA.Location = new System.Drawing.Point(49, 0);
            this.tbA.Maximum = 300;
            this.tbA.Minimum = 10;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(147, 33);
            this.tbA.TabIndex = 2;
            this.tbA.Value = 10;
            this.tbA.Scroll += new System.EventHandler(this.tbA_Scroll);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(196, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "300";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "10";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "A:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rbElip);
            this.panel7.Controls.Add(this.rbToaDoCuc);
            this.panel7.Controls.Add(this.rbMidpoint);
            this.panel7.Controls.Add(this.rbDecac);
            this.panel7.Location = new System.Drawing.Point(549, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(317, 100);
            this.panel7.TabIndex = 5;
            // 
            // rbElip
            // 
            this.rbElip.AutoSize = true;
            this.rbElip.Location = new System.Drawing.Point(170, 47);
            this.rbElip.Name = "rbElip";
            this.rbElip.Size = new System.Drawing.Size(52, 21);
            this.rbElip.TabIndex = 4;
            this.rbElip.TabStop = true;
            this.rbElip.Text = "Elip";
            this.rbElip.UseVisualStyleBackColor = true;
            this.rbElip.CheckedChanged += new System.EventHandler(this.rbElip_CheckedChanged);
            // 
            // rbToaDoCuc
            // 
            this.rbToaDoCuc.AutoSize = true;
            this.rbToaDoCuc.Location = new System.Drawing.Point(170, 4);
            this.rbToaDoCuc.Name = "rbToaDoCuc";
            this.rbToaDoCuc.Size = new System.Drawing.Size(104, 21);
            this.rbToaDoCuc.TabIndex = 2;
            this.rbToaDoCuc.TabStop = true;
            this.rbToaDoCuc.Text = "Toa Do Cuc";
            this.rbToaDoCuc.UseVisualStyleBackColor = true;
            this.rbToaDoCuc.CheckedChanged += new System.EventHandler(this.rbToaDoCuc_CheckedChanged);
            // 
            // rbMidpoint
            // 
            this.rbMidpoint.AutoSize = true;
            this.rbMidpoint.Location = new System.Drawing.Point(21, 47);
            this.rbMidpoint.Name = "rbMidpoint";
            this.rbMidpoint.Size = new System.Drawing.Size(82, 21);
            this.rbMidpoint.TabIndex = 1;
            this.rbMidpoint.TabStop = true;
            this.rbMidpoint.Text = "Midpoint";
            this.rbMidpoint.UseVisualStyleBackColor = true;
            this.rbMidpoint.CheckedChanged += new System.EventHandler(this.rbMidpoint_CheckedChanged);
            // 
            // rbDecac
            // 
            this.rbDecac.AutoSize = true;
            this.rbDecac.Checked = true;
            this.rbDecac.Location = new System.Drawing.Point(21, 4);
            this.rbDecac.Name = "rbDecac";
            this.rbDecac.Size = new System.Drawing.Size(71, 21);
            this.rbDecac.TabIndex = 0;
            this.rbDecac.TabStop = true;
            this.rbDecac.Text = "DeCac";
            this.rbDecac.UseVisualStyleBackColor = true;
            this.rbDecac.CheckedChanged += new System.EventHandler(this.rbDecac_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlRadius);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.gbElip);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.gbCenter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 200);
            this.panel1.TabIndex = 4;
            // 
            // pnlRadius
            // 
            this.pnlRadius.Controls.Add(this.panel9);
            this.pnlRadius.Controls.Add(this.label5);
            this.pnlRadius.Location = new System.Drawing.Point(27, 124);
            this.pnlRadius.Name = "pnlRadius";
            this.pnlRadius.Size = new System.Drawing.Size(403, 33);
            this.pnlRadius.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbRadius);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(58, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(345, 33);
            this.panel9.TabIndex = 1;
            // 
            // tbRadius
            // 
            this.tbRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRadius.Location = new System.Drawing.Point(49, 0);
            this.tbRadius.Maximum = 300;
            this.tbRadius.Minimum = 10;
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(247, 33);
            this.tbRadius.TabIndex = 2;
            this.tbRadius.Value = 10;
            this.tbRadius.Scroll += new System.EventHandler(this.tbRadius_Scroll);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(296, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "300";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "10";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Radius";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(763, 133);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(103, 39);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Clear";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // gbCenter
            // 
            this.gbCenter.Controls.Add(this.panel3);
            this.gbCenter.Controls.Add(this.panel5);
            this.gbCenter.Enabled = false;
            this.gbCenter.Location = new System.Drawing.Point(27, 16);
            this.gbCenter.Margin = new System.Windows.Forms.Padding(4);
            this.gbCenter.Name = "gbCenter";
            this.gbCenter.Padding = new System.Windows.Forms.Padding(4);
            this.gbCenter.Size = new System.Drawing.Size(179, 100);
            this.gbCenter.TabIndex = 1;
            this.gbCenter.TabStop = false;
            this.gbCenter.Text = "Center";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtY);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(8, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 23);
            this.panel3.TabIndex = 3;
            // 
            // txtY
            // 
            this.txtY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(72, 0);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(90, 22);
            this.txtY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Y:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtX);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(8, 23);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(162, 23);
            this.panel5.TabIndex = 2;
            // 
            // txtX
            // 
            this.txtX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(72, 0);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(90, 22);
            this.txtX.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "X:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbDraw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 500);
            this.panel2.TabIndex = 5;
            // 
            // pbDraw
            // 
            this.pbDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDraw.Location = new System.Drawing.Point(0, 0);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(900, 500);
            this.pbDraw.TabIndex = 0;
            this.pbDraw.TabStop = false;
            this.pbDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucCircle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucCircle";
            this.Size = new System.Drawing.Size(900, 700);
            this.gbElip.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlRadius.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadius)).EndInit();
            this.gbCenter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbElip;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rbElip;
        private System.Windows.Forms.RadioButton rbToaDoCuc;
        private System.Windows.Forms.RadioButton rbMidpoint;
        private System.Windows.Forms.RadioButton rbDecac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox gbCenter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRadius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TrackBar tbRadius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TrackBar tbA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}
