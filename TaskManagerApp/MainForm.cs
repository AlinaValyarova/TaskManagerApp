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
            MainDGV.Columns.Add("StatusName", "Статус");
            MainDGV.Columns.Add("TeamName", "Группа");
            MainDGV.Columns.Add("Deadline", "Дедлайн");
            MainDGV.Columns.Add("Finished", "Закончить");
            MainDGV.Columns.Add("Everyday", "Повторение");
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetDateTime(4), record.GetDateTime(5), record.GetInt32(6));
        }

        private void Reader(DataGridView dataGridView, int i)
        {
            string query1 = $"select User_Id, Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Not Done'";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }
        private void Reader1(DataGridView dataGridView, int i)
        {
            string query1 = $"select User_Id, Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Not Done' ' and TeamName = 'Private'";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }
        private void Reader2(DataGridView dataGridView, int i)
        {
            string query1 = $"select User_Id, Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Not Done' ' and TeamName = 'Common'";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {


            dataGridView.Rows.Clear();

            database.openConnetion();

            string query = $"select User_ID from Users where Email = '{Login.email}'";
            int person;
            SqlCommand command1 = new SqlCommand(query, database.getConnection());
            SqlDataReader reader = command1.ExecuteReader();
            reader.Read();
            Fill1();
            void Fill1()
            {
                person = reader.GetInt32(0);
            }
            reader.Close();

            Reader(dataGridView, person);
            



        }

        private void Archieve(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            DataBase dataBase = new DataBase();
            SqlDataReader reader;

            dataBase.openConnetion();


            string query = $"select User_ID from Users where Email = '{Login.email}'";
            int person;
            SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
            reader = command1.ExecuteReader();
            reader.Read();
            Fill();
            void Fill()
            {
                person = reader.GetInt32(0);
            }
            dataBase.closeConnetion();
            string query1 = $"select Name, Description, Status_ID, Team_Id, Deadline, Finished, Everyday from Tasks where User_Id = {person} and Status_ID = 1";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            database.openConnetion();

            SqlDataReader reader1 = command.ExecuteReader();

            while (reader1.Read())
            {
                ReadSingleRow(dataGridView, reader1);
            }
            reader1.Close();


        }

        private void RefreshDataGridCommon(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            DataBase dataBase = new DataBase();
            SqlDataReader reader;

            dataBase.openConnetion();


            string query = $"select User_ID from Users where Email = '{Login.email}'";
            int person;
            SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
            reader = command1.ExecuteReader();
            reader.Read();
            Fill();
            void Fill()
            {
                person = reader.GetInt32(0);
            }
            dataBase.closeConnetion();
            Reader2(MainDGV, person);

        }
        private void RefreshDataGridPrivate(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            DataBase dataBase = new DataBase();
            SqlDataReader reader;

            dataBase.openConnetion();


            string query = $"select User_ID from Users where Email = '{Login.email}'";
            int person;
            SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
            reader = command1.ExecuteReader();
            reader.Read();
            Fill();
            void Fill()
            {
                person = reader.GetInt32(0);
            }
            dataBase.closeConnetion();
            Reader1(MainDGV, person);

        }

        private void Future(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            DataBase dataBase = new DataBase();
            SqlDataReader reader;

            dataBase.openConnetion();


            string query = $"select User_ID from Users where Email = '{Login.email}'";
            int person;
            SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
            reader = command1.ExecuteReader();
            reader.Read();
            Fill();
            void Fill()
            {
                person = reader.GetInt32(0);
            }
            dataBase.closeConnetion();
            string query1 = $"select Name, Description, Status_Id, Team_Id, Deadline, Finished, Everyday from Tasks where User_Id = {person} and Team_Id = 1 and Status_ID = 2 and Deadline > getdate()";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            database.openConnetion();

            SqlDataReader reader1 = command.ExecuteReader();

            while (reader1.Read())
            {
                ReadSingleRow(dataGridView, reader1);
            }
            reader1.Close();
        }
        private void ArchieveTasksBtn_Click(object sender, EventArgs e)
        {
            Archieve(MainDGV);
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

        private void выйтиИзПрофиляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(MainDGV);
        }

        private void CommonTasksBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridCommon(MainDGV);
        }

        private void PrivateTasksBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridPrivate(MainDGV);
        }
        private void RefreshDataGridToday(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            DataBase dataBase = new DataBase();
            SqlDataReader reader;

            dataBase.openConnetion();


            string query = $"select User_ID from Users where Email = '{Login.email}'";
            int person;
            SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
            reader = command1.ExecuteReader();
            reader.Read();
            Fill1();
            void Fill1()
            {
                person = reader.GetInt32(0);
            }
            dataBase.closeConnetion();
            string query1 = $"select Name, Description, Status_Id, Team_Id, Deadline, Finished, Everyday from Tasks where User_Id = {person} and Status_ID = 2 and  Deadline = getdate()";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            database.openConnetion();

            SqlDataReader reader1 = command.ExecuteReader();

            while (reader1.Read())
            {
                ReadSingleRow(dataGridView, reader1);
            }
            reader1.Close();

        }

        

        private void TodayTasksBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridToday(MainDGV);
        }

        private void FutureTasksBtn_Click(object sender, EventArgs e)
        {
            Archieve(MainDGV);
        }
    }
}
