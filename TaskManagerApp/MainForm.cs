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

        public void CreateColums()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ArchieveTasksBtn_Click(object sender, EventArgs e)
        {

        }


        private void MainForm_Load(object sender, EventArgs e)
        {


            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source = HonkAppDataBase.mssql.somee.com;" + "Initial Catalog=HonkAppDataBase;" + "User id=cargoesbrr_SQLLogin_1;" + "Password=nchbzqmryy;";
                conn.Open();

                using (SqlCommand myQuery = new SqlCommand("SELECT * FROM Users;", conn))
                using (SqlDataReader myReader = myQuery.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        var usr = new User();

                        usr.User_ID = (int)myReader["User_Id"];
                        usr.Email = (string)myReader["Email"];
                        if (usr.Email == label2.Text)
                        {
                            user = usr;
                        }
                    }
                }

                using (SqlCommand myQuery = new SqlCommand("SELECT * FROM Tasks;", conn))
                using (SqlDataReader myReader = myQuery.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        var task = new Task();

                        task.Task_Id = (int)myReader["Task_Id"];
                        task.User_Id = (int)myReader["Task_Id"];
                        //task.Team_Id = (int)myReader["Team_Id"];/////подумать, как сделать так, чтобы записывался null
                        task.Status_Id = (int)myReader["Status_Id"];
                        task.Deadline = (DateTime)myReader["Deadline"];
                        //task.Finished = (DateTime?)myReader["Finished"];
                        //task.Description = (string)myReader["Description"];
                        task.Name = (string)myReader["Name"];
                        task.Everyday = (int)myReader["Everyday"];
                        //if (task.User_Id == ) ;
                        //&& task.Deadline == DateTime.Now
                        if (task.User_Id == user.User_ID)
                        {
                            tasks.Add(task);
                        }

                    }
                }
            }



            for (int i = 0; i < tasks.Count; i++)
            {
                Task task = new Task();
                task = tasks[i];
                checkedListBox1.Items.Add(task.Name);
            }

        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm(label2.Text);
            addTask.ShowDialog();

        }
    }
}
