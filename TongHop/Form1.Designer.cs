﻿namespace TongHop
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("RGB");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Lines");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Circle");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("CircleMove");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rectangle");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("WheelMove");
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
            this.panel1.Size = new System.Drawing.Size(286, 700);
            this.panel1.TabIndex = 0;
            // 
            // tvSelectProject
            // 
            this.tvSelectProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSelectProject.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvSelectProject.Indent = 40;
            this.tvSelectProject.ItemHeight = 50;
            this.tvSelectProject.Location = new System.Drawing.Point(0, 0);
            this.tvSelectProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvSelectProject.Name = "tvSelectProject";
            treeNode1.Name = "nRGB";
            treeNode1.Text = "RGB";
            treeNode2.Name = "nLines";
            treeNode2.Text = "Lines";
            treeNode3.Name = "nCircle";
            treeNode3.Text = "Circle";
            treeNode4.Name = "nCircleMove";
            treeNode4.Text = "CircleMove";
            treeNode5.Name = "nRectangle";
            treeNode5.Text = "Rectangle";
            treeNode6.Name = "nWheelMove";
            treeNode6.Text = "WheelMove";
            this.tvSelectProject.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.tvSelectProject.Size = new System.Drawing.Size(286, 700);
            this.tvSelectProject.TabIndex = 0;
            this.tvSelectProject.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSelectProject_NodeMouseClick);
            // 
            // pnlWindows
            // 
            this.pnlWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWindows.Location = new System.Drawing.Point(286, 0);
            this.pnlWindows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWindows.Name = "pnlWindows";
            this.pnlWindows.Size = new System.Drawing.Size(900, 700);
            this.pnlWindows.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1186, 700);
            this.Controls.Add(this.pnlWindows);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

