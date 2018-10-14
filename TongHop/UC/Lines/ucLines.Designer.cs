namespace TongHop.UC.Lines
{
    partial class ucLines
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
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rbShaded = new System.Windows.Forms.RadioButton();
            this.rbMidpoint = new System.Windows.Forms.RadioButton();
            this.rbDash = new System.Windows.Forms.RadioButton();
            this.rbBresenham = new System.Windows.Forms.RadioButton();
            this.rbBold = new System.Windows.Forms.RadioButton();
            this.rbDDA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDraw
            // 
            this.pbDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDraw.Location = new System.Drawing.Point(0, 0);
            this.pbDraw.Margin = new System.Windows.Forms.Padding(4);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(900, 500);
            this.pbDraw.TabIndex = 0;
            this.pbDraw.TabStop = false;
            this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseDown);
            this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseMove);
            this.pbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(27, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(179, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm bắt đầu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtY1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(8, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 23);
            this.panel3.TabIndex = 3;
            // 
            // txtY1
            // 
            this.txtY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY1.Location = new System.Drawing.Point(72, 0);
            this.txtY1.Margin = new System.Windows.Forms.Padding(4);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(90, 22);
            this.txtY1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Y1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtX1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(8, 23);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(162, 23);
            this.panel5.TabIndex = 2;
            // 
            // txtX1
            // 
            this.txtX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(72, 0);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(90, 22);
            this.txtX1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "X1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(753, 154);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(103, 39);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Clear";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbDraw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 500);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 200);
            this.panel1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rbShaded);
            this.panel7.Controls.Add(this.rbMidpoint);
            this.panel7.Controls.Add(this.rbDash);
            this.panel7.Controls.Add(this.rbBresenham);
            this.panel7.Controls.Add(this.rbBold);
            this.panel7.Controls.Add(this.rbDDA);
            this.panel7.Location = new System.Drawing.Point(401, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(465, 100);
            this.panel7.TabIndex = 5;
            // 
            // rbShaded
            // 
            this.rbShaded.AutoSize = true;
            this.rbShaded.Location = new System.Drawing.Point(323, 47);
            this.rbShaded.Name = "rbShaded";
            this.rbShaded.Size = new System.Drawing.Size(105, 21);
            this.rbShaded.TabIndex = 5;
            this.rbShaded.TabStop = true;
            this.rbShaded.Text = "ShadedLine";
            this.rbShaded.UseVisualStyleBackColor = true;
            this.rbShaded.CheckedChanged += new System.EventHandler(this.rbShaded_CheckedChanged);
            // 
            // rbMidpoint
            // 
            this.rbMidpoint.AutoSize = true;
            this.rbMidpoint.Location = new System.Drawing.Point(323, 4);
            this.rbMidpoint.Name = "rbMidpoint";
            this.rbMidpoint.Size = new System.Drawing.Size(82, 21);
            this.rbMidpoint.TabIndex = 4;
            this.rbMidpoint.TabStop = true;
            this.rbMidpoint.Text = "Midpoint";
            this.rbMidpoint.UseVisualStyleBackColor = true;
            this.rbMidpoint.CheckedChanged += new System.EventHandler(this.rbMidpoint_CheckedChanged);
            // 
            // rbDash
            // 
            this.rbDash.AutoSize = true;
            this.rbDash.Location = new System.Drawing.Point(170, 47);
            this.rbDash.Name = "rbDash";
            this.rbDash.Size = new System.Drawing.Size(89, 21);
            this.rbDash.TabIndex = 3;
            this.rbDash.TabStop = true;
            this.rbDash.Text = "DashLine";
            this.rbDash.UseVisualStyleBackColor = true;
            this.rbDash.CheckedChanged += new System.EventHandler(this.rbDash_CheckedChanged);
            // 
            // rbBresenham
            // 
            this.rbBresenham.AutoSize = true;
            this.rbBresenham.Location = new System.Drawing.Point(170, 4);
            this.rbBresenham.Name = "rbBresenham";
            this.rbBresenham.Size = new System.Drawing.Size(101, 21);
            this.rbBresenham.TabIndex = 2;
            this.rbBresenham.TabStop = true;
            this.rbBresenham.Text = "Bresenham";
            this.rbBresenham.UseVisualStyleBackColor = true;
            this.rbBresenham.CheckedChanged += new System.EventHandler(this.rbBresenham_CheckedChanged);
            // 
            // rbBold
            // 
            this.rbBold.AutoSize = true;
            this.rbBold.Location = new System.Drawing.Point(21, 47);
            this.rbBold.Name = "rbBold";
            this.rbBold.Size = new System.Drawing.Size(84, 21);
            this.rbBold.TabIndex = 1;
            this.rbBold.TabStop = true;
            this.rbBold.Text = "BoldLine";
            this.rbBold.UseVisualStyleBackColor = true;
            this.rbBold.CheckedChanged += new System.EventHandler(this.rbBold_CheckedChanged);
            // 
            // rbDDA
            // 
            this.rbDDA.AutoSize = true;
            this.rbDDA.Checked = true;
            this.rbDDA.Location = new System.Drawing.Point(21, 4);
            this.rbDDA.Name = "rbDDA";
            this.rbDDA.Size = new System.Drawing.Size(58, 21);
            this.rbDDA.TabIndex = 0;
            this.rbDDA.TabStop = true;
            this.rbDDA.Text = "DDA";
            this.rbDDA.UseVisualStyleBackColor = true;
            this.rbDDA.CheckedChanged += new System.EventHandler(this.rbDDA_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(214, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(179, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điểm kết thúc";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtY2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(8, 64);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 23);
            this.panel4.TabIndex = 3;
            // 
            // txtY2
            // 
            this.txtY2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY2.Location = new System.Drawing.Point(72, 0);
            this.txtY2.Margin = new System.Windows.Forms.Padding(4);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(90, 22);
            this.txtY2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtX2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(8, 23);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(162, 23);
            this.panel6.TabIndex = 2;
            // 
            // txtX2
            // 
            this.txtX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(72, 0);
            this.txtX2.Margin = new System.Windows.Forms.Padding(4);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(90, 22);
            this.txtX2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "X2:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucLines
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucLines";
            this.Size = new System.Drawing.Size(900, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rbShaded;
        private System.Windows.Forms.RadioButton rbMidpoint;
        private System.Windows.Forms.RadioButton rbDash;
        private System.Windows.Forms.RadioButton rbBresenham;
        private System.Windows.Forms.RadioButton rbBold;
        private System.Windows.Forms.RadioButton rbDDA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label4;
    }
}
