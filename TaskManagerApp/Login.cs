using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManagerApp
{
    public partial class Login : Form
    {
        

        DataBase database = new DataBase();
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NoAccLinkL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.ShowDialog();
        }
        public static string email;
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            
            email = UserEmailTB.Text;
            UserPasswordTB.UseSystemPasswordChar = true;
            var password = UserPasswordTB.Text; 
            

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();   

            DataTable dt = new DataTable();

            string querystring = $"select User_Id, Email, Password from dbo.Users where Email = '{email}' and Password = { password }";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен!","Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm(email);
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }

        private void UserEmailTB_MouseDown(object sender, MouseEventArgs e)
        {
            UserEmailTB.Clear();
        }

        private void UserPasswordTB_MouseDown(object sender, MouseEventArgs e)
        {
            UserPasswordTB.Clear();
        }

        private void UserPasswordTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
