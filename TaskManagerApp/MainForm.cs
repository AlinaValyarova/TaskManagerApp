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


            MainDGV.ReadOnly = false;

            MainDGV.Columns[0].ReadOnly = true;
            MainDGV.Columns[1].ReadOnly = true;
            MainDGV.Columns[3].ReadOnly = true;

            MainDGV.Columns[4].ReadOnly = true;
            MainDGV.Columns[5].ReadOnly = true;
            MainDGV.Columns[6].ReadOnly = true;

        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetDateTime(5), record.GetInt32(6));
        }
        private void ArchReader(DataGridView dataGridView, int i)
        {
            string query1 = $"select Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Done'";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }
        private void Reader(DataGridView dataGridView, int i)
        {
            string query1 = $"select Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Not Done'";

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
            string query1 = $"select Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Not Done' and TeamName = 'Private'";

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
            string query1 = $"select User_Id, Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Not Done'  and TeamName = 'Common'";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }
        private void Reader3(DataGridView dataGridView, int i)
        {
            string query1 = $"select User_Id, Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Not Done'  and Deadline < GetDate()";

            SqlCommand command = new SqlCommand(query1, database.getConnection());

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }
        private void Reader4(DataGridView dataGridView, int i)
        {
            string query1 = $"select User_Id, Name, Description, StatusName, TeamName, Deadline, Finished, Everyday  from Tasks ta join Statuses sa on ta.Status_ID = sa.idstatus join Teams te on ta.Team_Id = te.Team_ID  where User_Id = {i} and StatusName = 'Not Done'  and Deadline = GetDate()";

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
            ArchReader(MainDGV, person);


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
            Reader3(MainDGV, person);

        }
        private void ArchieveTasksBtn_Click(object sender, EventArgs e)
        {
            Archieve(MainDGV);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(MainDGV);
            if (MainDGV.Rows.Count == 0)
            {
                panel1.Visible = true;
            }

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
            Reader4(dataGridView, person);
            

        }


        private void MainForm_sizeChanged(object sender, EventArgs e)
        {
            MainDGV.Size = new Size(500, 300);
        }


        private void TodayTasksBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridToday(MainDGV);
        }

        private void FutureTasksBtn_Click(object sender, EventArgs e)
        {
            Future(MainDGV);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Change()
        {
            string some = MainDGV.CurrentRow.Cells[0].Value.ToString();
            string some1 = MainDGV.CurrentRow.Cells[2].Value.ToString();

            DataBase dataBase = new DataBase();
            SqlDataReader reader;

            dataBase.openConnetion();

            int f = 1;

           

            if (some1 == "Done")
            {
                f = 1;
            }

            else if(some1 == "Not Done")
            {
                f = 2;
            }


            string query = $"update Tasks set Status_ID = {f} where Name = '{some}' ";
            int person;
            SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
            reader = command1.ExecuteReader();
            reader.Read();
            dataBase.closeConnetion();



        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change();
        }
    }

}
