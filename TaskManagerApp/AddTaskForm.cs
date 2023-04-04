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
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }
     
       public void AddTaskForm_Load(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            DataBase dataBase = new DataBase();

            string queryregistration = $" insert into dbo.Users(Task_Id, User_Id, Team_Id, Status_id, Deadline, Finished, Description, Name, Everyday) values ({table.Rows.Count + 2},'{TaskName.Text}', '{lastname}','{email}',{password})";

            SqlCommand command = new SqlCommand(queryregistration, dataBase.getConnection());

            dataBase.openConnetion();

            if (command.ExecuteNonQuery() == 1)
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
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
