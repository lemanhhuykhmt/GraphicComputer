namespace TongHop
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vẽ bằng DDA");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Các đoạn thẳng", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvSelectProject = new System.Windows.Forms.TreeView();
            this.pnlWindows = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvSelectProject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 771);
            this.panel1.TabIndex = 0;
            // 
            // tvSelectProject
            // 
            this.tvSelectProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSelectProject.Location = new System.Drawing.Point(0, 0);
            this.tvSelectProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvSelectProject.Name = "tvSelectProject";
            treeNode1.Name = "nDDA";
            treeNode1.Text = "Vẽ bằng DDA";
            treeNode2.Name = "nLines";
            treeNode2.Text = "Các đoạn thẳng";
            this.tvSelectProject.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvSelectProject.Size = new System.Drawing.Size(286, 771);
            this.tvSelectProject.TabIndex = 0;
            // 
            // pnlWindows
            // 
            this.pnlWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWindows.Location = new System.Drawing.Point(286, 0);
            this.pnlWindows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWindows.Name = "pnlWindows";
            this.pnlWindows.Size = new System.Drawing.Size(1046, 771);
            this.pnlWindows.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 771);
            this.Controls.Add(this.pnlWindows);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvSelectProject;
        private System.Windows.Forms.Panel pnlWindows;
    }
}

