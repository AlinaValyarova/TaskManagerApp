namespace TaskManagerApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PanelTasks = new System.Windows.Forms.Panel();
            this.ArchieveTasksBtn = new System.Windows.Forms.Button();
            this.FutureTasksBtn = new System.Windows.Forms.Button();
            this.PrivateTasksBtn = new System.Windows.Forms.Button();
            this.CommonTasksBtn = new System.Windows.Forms.Button();
            this.TodayTasksBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.MainMenuStrip.SuspendLayout();
            this.PanelTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.AutoSize = false;
            this.MainMenuStrip.BackColor = System.Drawing.Color.LightCoral;
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMenuItem,
            this.HomeMenuItem,
            this.UserMenuItem,
            this.AddMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(946, 59);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // MenuMenuItem
            // 
            this.MenuMenuItem.AutoSize = false;
            this.MenuMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("MenuMenuItem.Image")));
            this.MenuMenuItem.Name = "MenuMenuItem";
            this.MenuMenuItem.Size = new System.Drawing.Size(70, 70);
            // 
            // HomeMenuItem
            // 
            this.HomeMenuItem.AutoSize = false;
            this.HomeMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HomeMenuItem.Image")));
            this.HomeMenuItem.Name = "HomeMenuItem";
            this.HomeMenuItem.Size = new System.Drawing.Size(70, 70);
            // 
            // UserMenuItem
            // 
            this.UserMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserMenuItem.AutoSize = false;
            this.UserMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserMenuItem.Image")));
            this.UserMenuItem.Name = "UserMenuItem";
            this.UserMenuItem.Size = new System.Drawing.Size(70, 70);
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AddMenuItem.AutoSize = false;
            this.AddMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddMenuItem.Image")));
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(70, 70);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PanelTasks
            // 
            this.PanelTasks.BackColor = System.Drawing.Color.White;
            this.PanelTasks.Controls.Add(this.ArchieveTasksBtn);
            this.PanelTasks.Controls.Add(this.FutureTasksBtn);
            this.PanelTasks.Controls.Add(this.PrivateTasksBtn);
            this.PanelTasks.Controls.Add(this.CommonTasksBtn);
            this.PanelTasks.Controls.Add(this.TodayTasksBtn);
            this.PanelTasks.Controls.Add(this.label2);
            this.PanelTasks.Location = new System.Drawing.Point(0, 54);
            this.PanelTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTasks.Name = "PanelTasks";
            this.PanelTasks.Size = new System.Drawing.Size(260, 504);
            this.PanelTasks.TabIndex = 1;
            // 
            // ArchieveTasksBtn
            // 
            this.ArchieveTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ArchieveTasksBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArchieveTasksBtn.Location = new System.Drawing.Point(11, 171);
            this.ArchieveTasksBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArchieveTasksBtn.Name = "ArchieveTasksBtn";
            this.ArchieveTasksBtn.Size = new System.Drawing.Size(231, 26);
            this.ArchieveTasksBtn.TabIndex = 4;
            this.ArchieveTasksBtn.Text = "архив";
            this.ArchieveTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArchieveTasksBtn.UseVisualStyleBackColor = true;
            this.ArchieveTasksBtn.Click += new System.EventHandler(this.ArchieveTasksBtn_Click);
            // 
            // FutureTasksBtn
            // 
            this.FutureTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FutureTasksBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FutureTasksBtn.Location = new System.Drawing.Point(11, 130);
            this.FutureTasksBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FutureTasksBtn.Name = "FutureTasksBtn";
            this.FutureTasksBtn.Size = new System.Drawing.Size(231, 26);
            this.FutureTasksBtn.TabIndex = 3;
            this.FutureTasksBtn.Text = "предстоящие";
            this.FutureTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FutureTasksBtn.UseVisualStyleBackColor = true;
            // 
            // PrivateTasksBtn
            // 
            this.PrivateTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrivateTasksBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrivateTasksBtn.Location = new System.Drawing.Point(61, 88);
            this.PrivateTasksBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrivateTasksBtn.Name = "PrivateTasksBtn";
            this.PrivateTasksBtn.Size = new System.Drawing.Size(180, 26);
            this.PrivateTasksBtn.TabIndex = 2;
            this.PrivateTasksBtn.Text = "личные";
            this.PrivateTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrivateTasksBtn.UseVisualStyleBackColor = true;
            // 
            // CommonTasksBtn
            // 
            this.CommonTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CommonTasksBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommonTasksBtn.Location = new System.Drawing.Point(61, 57);
            this.CommonTasksBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommonTasksBtn.Name = "CommonTasksBtn";
            this.CommonTasksBtn.Size = new System.Drawing.Size(180, 26);
            this.CommonTasksBtn.TabIndex = 1;
            this.CommonTasksBtn.Text = "общие";
            this.CommonTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommonTasksBtn.UseVisualStyleBackColor = true;
            this.CommonTasksBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TodayTasksBtn
            // 
            this.TodayTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TodayTasksBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodayTasksBtn.Location = new System.Drawing.Point(11, 26);
            this.TodayTasksBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TodayTasksBtn.Name = "TodayTasksBtn";
            this.TodayTasksBtn.Size = new System.Drawing.Size(231, 26);
            this.TodayTasksBtn.TabIndex = 0;
            this.TodayTasksBtn.Text = "cегодня";
            this.TodayTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TodayTasksBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(281, 54);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(665, 514);
            this.checkedListBox1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(946, 558);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.PanelTasks);
            this.Controls.Add(this.MainMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.PanelTasks.ResumeLayout(false);
            this.PanelTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.Panel PanelTasks;
        private System.Windows.Forms.Button TodayTasksBtn;
        private System.Windows.Forms.Button CommonTasksBtn;
        private System.Windows.Forms.Button ArchieveTasksBtn;
        private System.Windows.Forms.Button FutureTasksBtn;
        private System.Windows.Forms.Button PrivateTasksBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

