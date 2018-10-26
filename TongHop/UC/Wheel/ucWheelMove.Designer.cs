namespace TongHop.UC.Wheel
{
    partial class ucWheelMove
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlVelocity = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbVelocity = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearOrStop = new System.Windows.Forms.Button();
            this.btnStartOrPause = new System.Windows.Forms.Button();
            this.pnlRotate = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbRotate = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlVelocity.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVelocity)).BeginInit();
            this.pnlRotate.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbDraw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 497);
            this.panel1.TabIndex = 0;
            // 
            // pbDraw
            // 
            this.pbDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDraw.Location = new System.Drawing.Point(0, 0);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(900, 497);
            this.pbDraw.TabIndex = 0;
            this.pbDraw.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlVelocity);
            this.panel2.Controls.Add(this.btnClearOrStop);
            this.panel2.Controls.Add(this.btnStartOrPause);
            this.panel2.Controls.Add(this.pnlRotate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 203);
            this.panel2.TabIndex = 1;
            // 
            // pnlVelocity
            // 
            this.pnlVelocity.Controls.Add(this.panel4);
            this.pnlVelocity.Controls.Add(this.label3);
            this.pnlVelocity.Location = new System.Drawing.Point(466, 95);
            this.pnlVelocity.Name = "pnlVelocity";
            this.pnlVelocity.Size = new System.Drawing.Size(403, 36);
            this.pnlVelocity.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbVelocity);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(96, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 36);
            this.panel4.TabIndex = 1;
            // 
            // tbVelocity
            // 
            this.tbVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVelocity.LargeChange = 1;
            this.tbVelocity.Location = new System.Drawing.Point(49, 0);
            this.tbVelocity.Maximum = 3;
            this.tbVelocity.Name = "tbVelocity";
            this.tbVelocity.Size = new System.Drawing.Size(209, 36);
            this.tbVelocity.TabIndex = 2;
            this.tbVelocity.Value = 1;
            this.tbVelocity.Scroll += new System.EventHandler(this.tbVelocity_Scroll);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Velocity: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearOrStop
            // 
            this.btnClearOrStop.Enabled = false;
            this.btnClearOrStop.Location = new System.Drawing.Point(65, 109);
            this.btnClearOrStop.Name = "btnClearOrStop";
            this.btnClearOrStop.Size = new System.Drawing.Size(93, 49);
            this.btnClearOrStop.TabIndex = 8;
            this.btnClearOrStop.Text = "Clear";
            this.btnClearOrStop.UseVisualStyleBackColor = true;
            this.btnClearOrStop.Click += new System.EventHandler(this.btnClearOrStop_Click);
            // 
            // btnStartOrPause
            // 
            this.btnStartOrPause.Location = new System.Drawing.Point(63, 38);
            this.btnStartOrPause.Name = "btnStartOrPause";
            this.btnStartOrPause.Size = new System.Drawing.Size(93, 49);
            this.btnStartOrPause.TabIndex = 9;
            this.btnStartOrPause.Text = "Start";
            this.btnStartOrPause.UseVisualStyleBackColor = true;
            this.btnStartOrPause.Click += new System.EventHandler(this.btnStartOrPause_Click);
            // 
            // pnlRotate
            // 
            this.pnlRotate.Controls.Add(this.panel9);
            this.pnlRotate.Controls.Add(this.label5);
            this.pnlRotate.Location = new System.Drawing.Point(466, 27);
            this.pnlRotate.Name = "pnlRotate";
            this.pnlRotate.Size = new System.Drawing.Size(403, 36);
            this.pnlRotate.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbRotate);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(96, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(307, 36);
            this.panel9.TabIndex = 1;
            // 
            // tbRotate
            // 
            this.tbRotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRotate.Location = new System.Drawing.Point(49, 0);
            this.tbRotate.Maximum = 3;
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Size = new System.Drawing.Size(209, 36);
            this.tbRotate.TabIndex = 2;
            this.tbRotate.Value = 1;
            this.tbRotate.Scroll += new System.EventHandler(this.tbRotate_Scroll);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(258, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 36);
            this.label7.TabIndex = 1;
            this.label7.Text = "3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rotate: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucWheelMove
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucWheelMove";
            this.Size = new System.Drawing.Size(900, 700);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlVelocity.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVelocity)).EndInit();
            this.pnlRotate.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlRotate;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TrackBar tbRotate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearOrStop;
        private System.Windows.Forms.Button btnStartOrPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlVelocity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar tbVelocity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
