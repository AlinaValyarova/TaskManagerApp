
namespace TaskManagerApp
{
    partial class ForgotPassword
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
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginL.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.LoginL.Location = new System.Drawing.Point(52, 45);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(282, 31);
            this.LoginL.TabIndex = 2;
            this.LoginL.Text = "Напоминание пароля";
            // 
            // UserEmailTB
            // 
            this.UserEmailTB.BackColor = System.Drawing.Color.LightGray;
            this.UserEmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmailTB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmailTB.ForeColor = System.Drawing.Color.Black;
            this.UserEmailTB.Location = new System.Drawing.Point(52, 117);
            this.UserEmailTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserEmailTB.Name = "UserEmailTB";
            this.UserEmailTB.Size = new System.Drawing.Size(282, 22);
            this.UserEmailTB.TabIndex = 4;
            this.UserEmailTB.Text = "E-mail";
            this.UserEmailTB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserEmailTB_MouseDown);
            // 
            // LoginBTN
            // 
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBTN.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.LoginBTN.Location = new System.Drawing.Point(64, 168);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(252, 36);
            this.LoginBTN.TabIndex = 6;
            this.LoginBTN.Text = "Отправить пароль";
            this.LoginBTN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(429, 249);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.UserEmailTB);
            this.Controls.Add(this.LoginL);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.TextBox UserEmailTB;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label2;
    }
}