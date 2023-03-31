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

namespace TaskManagerApp
{
    public partial class RegistrationForm : Form
    {
    

        DataBase database = new DataBase();
        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationBTN_Click(object sender, EventArgs e)
        {

            DataBase dataBase = new DataBase();
            if (CheckingUser())

            {
                return;
            }
            var username = UserNameTB.Text;
            var email = UserEmailTB.Text;
            var password = UserPasswordTB.Text;

            string queryregistration = $" insert into dbo.TMUsers(username, email, userpassword) values ('{username}', '{email}', {password})";

            SqlCommand command = new SqlCommand(queryregistration, dataBase.getConnection());

            dataBase.openConnetion();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно!", "Успех!");
                Login login = new Login();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            dataBase.closeConnetion();
        }

        private Boolean CheckingUser()
        {
            var email = UserEmailTB.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querychecking = $"select id, username, email, userpassword from dbo.TMUsers where email = '{email}'";

            SqlCommand command = new SqlCommand(querychecking, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Этот E-mail уже закреплен за другим пользователем!");
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
