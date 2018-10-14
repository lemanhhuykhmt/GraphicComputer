namespace TongHop.UC.CircleMove
{
    partial class CircleMove
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbDraw = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVelocity = new System.Windows.Forms.TrackBar();
            this.pnlRadius = new System.Windows.Forms.Panel();
            this.btnStartOrPause = new System.Windows.Forms.Button();
            this.btnClearOrStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVelocity)).BeginInit();
            this.pnlRadius.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pbDraw);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(185, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 700);
            this.panel4.TabIndex = 2;
            // 
            // pbDraw
            // 
            this.pbDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDraw.Location = new System.Drawing.Point(0, 0);
            this.pbDraw.Name = "pbDraw";
            this.pbDraw.Size = new System.Drawing.Size(715, 700);
            this.pbDraw.TabIndex = 0;
            this.pbDraw.TabStop = false;
            this.pbDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDraw_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlRadius);
            this.panel3.Controls.Add(this.btnRotate);
            this.panel3.Controls.Add(this.btnClearOrStop);
            this.panel3.Controls.Add(this.btnStartOrPause);
            this.panel3.Controls.Add(this.btnTranslate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 700);
            this.panel3.TabIndex = 1;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(36, 108);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(93, 49);
            this.btnRotate.TabIndex = 0;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(36, 34);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(93, 49);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Velocity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbVelocity);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 40);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(65, 344);
            this.panel9.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 45);
            this.label7.TabIndex = 1;
            this.label7.Text = "500";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbVelocity
            // 
            this.tbVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVelocity.Location = new System.Drawing.Point(0, 27);
            this.tbVelocity.Maximum = 500;
            this.tbVelocity.Name = "tbVelocity";
            this.tbVelocity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVelocity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVelocity.Size = new System.Drawing.Size(65, 272);
            this.tbVelocity.SmallChange = 10;
            this.tbVelocity.TabIndex = 2;
            this.tbVelocity.Value = 100;
            this.tbVelocity.Scroll += new System.EventHandler(this.tbVelocity_Scroll);
            // 
            // pnlRadius
            // 
            this.pnlRadius.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlRadius.Controls.Add(this.panel9);
            this.pnlRadius.Controls.Add(this.label5);
            this.pnlRadius.Location = new System.Drawing.Point(20, 304);
            this.pnlRadius.Name = "pnlRadius";
            this.pnlRadius.Size = new System.Drawing.Size(65, 384);
            this.pnlRadius.TabIndex = 7;
            // 
            // btnStartOrPause
            // 
            this.btnStartOrPause.Location = new System.Drawing.Point(89, 344);
            this.btnStartOrPause.Name = "btnStartOrPause";
            this.btnStartOrPause.Size = new System.Drawing.Size(93, 49);
            this.btnStartOrPause.TabIndex = 0;
            this.btnStartOrPause.Text = "Start";
            this.btnStartOrPause.UseVisualStyleBackColor = true;
            this.btnStartOrPause.Click += new System.EventHandler(this.btnStartOrPause_Click);
            // 
            // btnClearOrStop
            // 
            this.btnClearOrStop.Enabled = false;
            this.btnClearOrStop.Location = new System.Drawing.Point(91, 415);
            this.btnClearOrStop.Name = "btnClearOrStop";
            this.btnClearOrStop.Size = new System.Drawing.Size(93, 49);
            this.btnClearOrStop.TabIndex = 0;
            this.btnClearOrStop.Text = "Clear";
            this.btnClearOrStop.UseVisualStyleBackColor = true;
            this.btnClearOrStop.Click += new System.EventHandler(this.btnClearOrStop_Click);
            // 
            // CircleMove
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "CircleMove";
            this.Size = new System.Drawing.Size(900, 700);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVelocity)).EndInit();
            this.pnlRadius.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbDraw;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlRadius;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TrackBar tbVelocity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearOrStop;
        private System.Windows.Forms.Button btnStartOrPause;
    }
}
