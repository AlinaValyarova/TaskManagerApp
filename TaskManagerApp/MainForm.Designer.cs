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
            this.HomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПрофиляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PanelTasks = new System.Windows.Forms.Panel();
            this.ArchieveTasksBtn = new System.Windows.Forms.Button();
            this.FutureTasksBtn = new System.Windows.Forms.Button();
            this.PrivateTasksBtn = new System.Windows.Forms.Button();
            this.CommonTasksBtn = new System.Windows.Forms.Button();
            this.TodayTasksBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.MainDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenuStrip.SuspendLayout();
            this.PanelTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.AutoSize = false;
            this.MainMenuStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenuItem,
            this.UserMenuItem,
            this.AddMenuItem,
            this.refreshToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.MainMenuStrip.Size = new System.Drawing.Size(946, 59);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
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
            this.UserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзПрофиляToolStripMenuItem});
            this.UserMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserMenuItem.Image")));
            this.UserMenuItem.Name = "UserMenuItem";
            this.UserMenuItem.Size = new System.Drawing.Size(152, 70);
            // 
            // выйтиИзПрофиляToolStripMenuItem
            // 
            this.выйтиИзПрофиляToolStripMenuItem.Name = "выйтиИзПрофиляToolStripMenuItem";
            this.выйтиИзПрофиляToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.выйтиИзПрофиляToolStripMenuItem.Text = "выйти из профиля";
            this.выйтиИзПрофиляToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПрофиляToolStripMenuItem_Click);
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AddMenuItem.AutoSize = false;
            this.AddMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddMenuItem.Image")));
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(152, 70);
            this.AddMenuItem.Click += new System.EventHandler(this.AddMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshToolStripMenuItem.AutoSize = false;
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(70, 70);
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PanelTasks
            // 
            this.PanelTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.FutureTasksBtn.Click += new System.EventHandler(this.FutureTasksBtn_Click);
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
            this.PrivateTasksBtn.Click += new System.EventHandler(this.PrivateTasksBtn_Click);
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
            this.CommonTasksBtn.Click += new System.EventHandler(this.CommonTasksBtn_Click);
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
            this.TodayTasksBtn.Click += new System.EventHandler(this.TodayTasksBtn_Click);
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
            // MainDGV
            // 
            this.MainDGV.AllowUserToAddRows = false;
            this.MainDGV.AllowUserToDeleteRows = false;
            this.MainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDGV.Location = new System.Drawing.Point(280, 54);
            this.MainDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainDGV.Name = "MainDGV";
            this.MainDGV.ReadOnly = true;
            this.MainDGV.RowHeadersWidth = 62;
            this.MainDGV.RowTemplate.Height = 28;
            this.MainDGV.Size = new System.Drawing.Size(666, 504);
            this.MainDGV.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(280, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 514);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(67, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нажмите +, чтобы добавить задачу";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(946, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainDGV);
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
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserMenuItem;
        private System.Windows.Forms.Panel PanelTasks;
        private System.Windows.Forms.Button TodayTasksBtn;
        private System.Windows.Forms.Button CommonTasksBtn;
        private System.Windows.Forms.Button ArchieveTasksBtn;
        private System.Windows.Forms.Button FutureTasksBtn;
        private System.Windows.Forms.Button PrivateTasksBtn;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.DataGridView MainDGV;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПрофиляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

