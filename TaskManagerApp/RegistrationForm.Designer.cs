namespace TaskManagerApp
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.UserEmailTB = new System.Windows.Forms.TextBox();
            this.UserPasswordTB = new System.Windows.Forms.TextBox();
            this.RegistrationBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(98, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создать аккаунт";
            // 
            // UserNameTB
            // 
            this.UserNameTB.BackColor = System.Drawing.Color.LightGray;
            this.UserNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameTB.ForeColor = System.Drawing.Color.Black;
            this.UserNameTB.Location = new System.Drawing.Point(66, 164);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(317, 26);
            this.UserNameTB.TabIndex = 1;
            this.UserNameTB.Text = "Имя пользователя";
            // 
            // UserEmailTB
            // 
            this.UserEmailTB.BackColor = System.Drawing.Color.LightGray;
            this.UserEmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmailTB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmailTB.ForeColor = System.Drawing.Color.Black;
            this.UserEmailTB.Location = new System.Drawing.Point(66, 212);
            this.UserEmailTB.Name = "UserEmailTB";
            this.UserEmailTB.Size = new System.Drawing.Size(317, 26);
            this.UserEmailTB.TabIndex = 2;
            this.UserEmailTB.Text = "E-mail";
            // 
            // UserPasswordTB
            // 
            this.UserPasswordTB.BackColor = System.Drawing.Color.LightGray;
            this.UserPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordTB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordTB.ForeColor = System.Drawing.Color.Black;
            this.UserPasswordTB.Location = new System.Drawing.Point(66, 258);
            this.UserPasswordTB.Name = "UserPasswordTB";
            this.UserPasswordTB.Size = new System.Drawing.Size(317, 26);
            this.UserPasswordTB.TabIndex = 3;
            this.UserPasswordTB.Text = "Пароль";
            // 
            // RegistrationBTN
            // 
            this.RegistrationBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationBTN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationBTN.Location = new System.Drawing.Point(66, 326);
            this.RegistrationBTN.Name = "RegistrationBTN";
            this.RegistrationBTN.Size = new System.Drawing.Size(302, 45);
            this.RegistrationBTN.TabIndex = 4;
            this.RegistrationBTN.Text = "Зарегистрироваться";
            this.RegistrationBTN.UseVisualStyleBackColor = true;
            this.RegistrationBTN.Click += new System.EventHandler(this.RegistrationBTN_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.RegistrationBTN);
            this.Controls.Add(this.UserPasswordTB);
            this.Controls.Add(this.UserEmailTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox UserEmailTB;
        private System.Windows.Forms.TextBox UserPasswordTB;
        private System.Windows.Forms.Button RegistrationBTN;
    }
}