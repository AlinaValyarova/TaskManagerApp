namespace TaskManagerApp
{
    partial class Login
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
            this.LoginL = new System.Windows.Forms.Label();
            this.UserEmailTB = new System.Windows.Forms.TextBox();
            this.UserPasswordTB = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.NoAccL = new System.Windows.Forms.Label();
            this.NoAccLinkL = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginL.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.LoginL.Location = new System.Drawing.Point(89, 83);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(219, 31);
            this.LoginL.TabIndex = 1;
            this.LoginL.Text = "Войти в аккаунт";
            // 
            // UserEmailTB
            // 
            this.UserEmailTB.BackColor = System.Drawing.Color.LightGray;
            this.UserEmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmailTB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmailTB.ForeColor = System.Drawing.Color.Black;
            this.UserEmailTB.Location = new System.Drawing.Point(62, 147);
            this.UserEmailTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserEmailTB.Name = "UserEmailTB";
            this.UserEmailTB.Size = new System.Drawing.Size(282, 22);
            this.UserEmailTB.TabIndex = 3;
            this.UserEmailTB.Text = "E-mail";
            // 
            // UserPasswordTB
            // 
            this.UserPasswordTB.BackColor = System.Drawing.Color.LightGray;
            this.UserPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordTB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordTB.ForeColor = System.Drawing.Color.Black;
            this.UserPasswordTB.Location = new System.Drawing.Point(62, 186);
            this.UserPasswordTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPasswordTB.Name = "UserPasswordTB";
            this.UserPasswordTB.Size = new System.Drawing.Size(282, 22);
            this.UserPasswordTB.TabIndex = 4;
            this.UserPasswordTB.Text = "Пароль";
            // 
            // LoginBTN
            // 
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBTN.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.LoginBTN.Location = new System.Drawing.Point(105, 231);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(196, 36);
            this.LoginBTN.TabIndex = 5;
            this.LoginBTN.Text = "Войти";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // NoAccL
            // 
            this.NoAccL.AutoSize = true;
            this.NoAccL.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoAccL.Location = new System.Drawing.Point(152, 278);
            this.NoAccL.Name = "NoAccL";
            this.NoAccL.Size = new System.Drawing.Size(88, 16);
            this.NoAccL.TabIndex = 6;
            this.NoAccL.Text = "Нет аккаунта?";
            // 
            // NoAccLinkL
            // 
            this.NoAccLinkL.AutoSize = true;
            this.NoAccLinkL.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoAccLinkL.Location = new System.Drawing.Point(138, 294);
            this.NoAccLinkL.Name = "NoAccLinkL";
            this.NoAccLinkL.Size = new System.Drawing.Size(124, 16);
            this.NoAccLinkL.TabIndex = 7;
            this.NoAccLinkL.TabStop = true;
            this.NoAccLinkL.Text = "Зарегистрироваться";
            this.NoAccLinkL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoAccLinkL_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(138, 321);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Забыли пароль?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 360);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.NoAccLinkL);
            this.Controls.Add(this.NoAccL);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.UserPasswordTB);
            this.Controls.Add(this.UserEmailTB);
            this.Controls.Add(this.LoginL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.TextBox UserEmailTB;
        private System.Windows.Forms.TextBox UserPasswordTB;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label NoAccL;
        private System.Windows.Forms.LinkLabel NoAccLinkL;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}