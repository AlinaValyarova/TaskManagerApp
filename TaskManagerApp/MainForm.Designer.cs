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
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.MainMenuStrip.SuspendLayout();
            this.PanelTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.AutoSize = false;
            this.MainMenuStrip.BackColor = System.Drawing.Color.LightCoral;
            this.MainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMenuItem,
            this.HomeMenuItem,
            this.UserMenuItem,
            this.AddMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1071, 74);
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
            this.PanelTasks.Location = new System.Drawing.Point(0, 68);
            this.PanelTasks.Name = "PanelTasks";
            this.PanelTasks.Size = new System.Drawing.Size(293, 630);
            this.PanelTasks.TabIndex = 1;
            // 
            // ArchieveTasksBtn
            // 
            this.ArchieveTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ArchieveTasksBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArchieveTasksBtn.Location = new System.Drawing.Point(12, 214);
            this.ArchieveTasksBtn.Name = "ArchieveTasksBtn";
            this.ArchieveTasksBtn.Size = new System.Drawing.Size(260, 33);
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
            this.FutureTasksBtn.Location = new System.Drawing.Point(12, 163);
            this.FutureTasksBtn.Name = "FutureTasksBtn";
            this.FutureTasksBtn.Size = new System.Drawing.Size(260, 33);
            this.FutureTasksBtn.TabIndex = 3;
            this.FutureTasksBtn.Text = "предстоящие";
            this.FutureTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FutureTasksBtn.UseVisualStyleBackColor = true;
            // 
            // PrivateTasksBtn
            // 
            this.PrivateTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrivateTasksBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrivateTasksBtn.Location = new System.Drawing.Point(69, 110);
            this.PrivateTasksBtn.Name = "PrivateTasksBtn";
            this.PrivateTasksBtn.Size = new System.Drawing.Size(203, 33);
            this.PrivateTasksBtn.TabIndex = 2;
            this.PrivateTasksBtn.Text = "личные";
            this.PrivateTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrivateTasksBtn.UseVisualStyleBackColor = true;
            // 
            // CommonTasksBtn
            // 
            this.CommonTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CommonTasksBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommonTasksBtn.Location = new System.Drawing.Point(69, 71);
            this.CommonTasksBtn.Name = "CommonTasksBtn";
            this.CommonTasksBtn.Size = new System.Drawing.Size(203, 33);
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
            this.TodayTasksBtn.Location = new System.Drawing.Point(12, 32);
            this.TodayTasksBtn.Name = "TodayTasksBtn";
            this.TodayTasksBtn.Size = new System.Drawing.Size(260, 33);
            this.TodayTasksBtn.TabIndex = 0;
            this.TodayTasksBtn.Text = "cегодня";
            this.TodayTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TodayTasksBtn.UseVisualStyleBackColor = true;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            this.MainDataGridView.AllowUserToDeleteRows = false;
            this.MainDataGridView.BackgroundColor = System.Drawing.Color.Orchid;
            this.MainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Location = new System.Drawing.Point(290, 68);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.RowHeadersWidth = 62;
            this.MainDataGridView.RowTemplate.Height = 28;
            this.MainDataGridView.Size = new System.Drawing.Size(781, 630);
            this.MainDataGridView.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1071, 698);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.PanelTasks);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.PanelTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView MainDataGridView;
    }
}

