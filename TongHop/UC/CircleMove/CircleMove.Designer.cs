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
            this.pnlRadius = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnClearOrStop = new System.Windows.Forms.Button();
            this.btnStartOrPause = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlRadius.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
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
            // panel9
            // 
            this.panel9.Controls.Add(this.tbSpeed);
            this.panel9.Controls.Add(this.lbMin);
            this.panel9.Controls.Add(this.lbMax);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 40);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(65, 344);
            this.panel9.TabIndex = 1;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSpeed.Location = new System.Drawing.Point(0, 27);
            this.tbSpeed.Maximum = 500;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSpeed.Size = new System.Drawing.Size(65, 272);
            this.tbSpeed.SmallChange = 10;
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.Value = 100;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // lbMin
            // 
            this.lbMin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMin.Location = new System.Drawing.Point(0, 299);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(65, 45);
            this.lbMin.TabIndex = 1;
            this.lbMin.Text = "0";
            this.lbMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMax
            // 
            this.lbMax.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMax.Location = new System.Drawing.Point(0, 0);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(65, 27);
            this.lbMax.TabIndex = 0;
            this.lbMax.Text = "500";
            this.lbMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlRadius.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
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
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearOrStop;
        private System.Windows.Forms.Button btnStartOrPause;
    }
}
