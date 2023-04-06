using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerApp
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,
    }

    public partial class MainForm : Form
    {
        public class Task
        {
            public int Task_Id { get; set; }
            public int User_Id { get; set; }
            public int? Team_Id { get; set; }
            public int Status_Id { get; set; }
            public DateTime Deadline { get; set; }
            public DateTime? Finished { get; set; }
            public string Description { get; set; }
            public string Name { get; set; }
            public int Everyday { get; set; }
        }

        public class User
        {
            public int User_ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public int Password { get; set; }
        }
        DataBase database = new DataBase();
        List<Task> tasks = new List<Task>();
        User user = new User();

        public MainForm(string str)
        {
            InitializeComponent();

            label2.Text = str;
            AddMenuItem.Click += AddMenuItem_Click;


        }
        private void CreateColumns()
        {
            MainDGV.Columns.Add("Name", "Задача");
            MainDGV.Columns.Add("Description", "Описание");
            MainDGV.Columns.Add("Status_Id", "Статус");
            MainDGV.Columns.Add("Team_Id", "Группа");
            MainDGV.Columns.Add("Deadline", "Дедлайн");
            MainDGV.Columns.Add("Finished", "Закончить");
            MainDGV.Columns.Add("Everyday", "Повторение");
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetDateTime(4), record.GetDateTime(5), record.GetInt32(6));
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string query1 = $"select Name, Description, Status_Id, Team_Id, Deadline, Finished, Everyday from Tasks";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            database.openConnetion();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();

        }
        private void ArchieveTasksBtn_Click(object sender, EventArgs e)
        {

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(MainDGV);

        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm(label2.Text);
            addTask.ShowDialog();

        }
    }
}
