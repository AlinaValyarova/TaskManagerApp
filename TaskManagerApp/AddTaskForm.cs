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
        public class Team
        {
            public int Team_ID;
            public string Team_Name;
        }


        MainForm.User user = new MainForm.User();
        int everyday;
        string selectedState;
        int teamIndex;
        int usrID;
        List<Team> listOfTeams = new List<Team>();
        public AddTaskForm(string str)
        {
            InitializeComponent();
            label1.Text = str;
            DoToDTP.Format = DateTimePickerFormat.Short;
            DoToDTP.ValueChanged += dateTimePicker1_ValueChanged;
            Teams.SelectedIndexChanged += Teams_SelectedIndexChanged;
            AddTaskBTN.Click += AddTaskBTN_Click;
            

        }

        private void Teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = Teams.SelectedItem.ToString();

            if(selectedState.Equals("+ Создать новую команду"))
            {
                AddTeamForm addTF = new AddTeamForm();
                addTF.ShowDialog();
            }
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                everyday = 1;
            }
            else
            {
                everyday = 0;
            }
        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = DoToDTP.Value.ToString();
        }
       

        public void AddTaskForm_Load(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            DataBase dataBase = new DataBase();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source = HonkAppDataBase.mssql.somee.com;" + "Initial Catalog=HonkAppDataBase;" + "User id=cargoesbrr_SQLLogin_1;" + "Password=nchbzqmryy;";
                conn.Open();

                using (SqlCommand myQuery = new SqlCommand("SELECT * FROM Users;", conn))
                using (SqlDataReader myReader = myQuery.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        var usr = new MainForm.User();

                        usr.User_ID = (int)myReader["User_Id"];
                        usr.Email = (string)myReader["Email"];
                        if (usr.Email == label1.Text)
                        {
                            user = usr;
                            usrID = usr.User_ID;
                        }
                    }
                }

                using (SqlCommand myQuery = new SqlCommand("SELECT * FROM Teams;", conn))
                using (SqlDataReader myReader = myQuery.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        var tm = new Team();

                        tm.Team_ID = (int)myReader["User_Id"];
                        tm.Team_Name = (string)myReader["Email"];
                        listOfTeams.Add(tm);
                    }
                }
            }

            foreach(Team a in listOfTeams)
            {
                if (a.Team_Name.Equals(Teams.SelectedItem))
                {
                    teamIndex = a.Team_ID;
                }
            }


        }


        
        private void AddTaskBTN_Click(object sender, EventArgs e)
        {
            int teams = 0;
            switch (Teams.SelectedItem)
            {
                case "Личная":
                    teams = 1;
                    break;
                case "Общая":
                    teams = 2;
                    break;
                default:
                    teams = 2;
                    break;
            }
            int status = 0;
            if(RepeatingCheckBox.Checked == true)
            {
                status = 1;
            }
            else { status = 0; }
            DataTable table = new DataTable();
            DataBase dataBase = new DataBase();

            DateTime result = DeadLintDTP.Value;
            this.Text = result.ToString();
            DateTime result1 = DoToDTP.Value;
            this.Text = result1.ToString();

            string taskname = TaskName.Text;
            string description = Description.Text;

            string addtask = $" insert into Tasks(User_Id, Team_Id, Status_Id, Deadline, Finished, Name, Description, Everyday) values (1, {teams}, 1 , '{result}', '{result1}', '{taskname}', '{description}', {status})";
            SqlCommand command = new SqlCommand(addtask, dataBase.getConnection());

            dataBase.openConnetion();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавлена новая задача!", "Успех!");
               
            }
            else
            {
                MessageBox.Show("Задача не создана");
            }
            dataBase.closeConnetion();

        }
    }
}
