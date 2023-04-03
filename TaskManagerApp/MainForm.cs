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
        List<Tuple<int, DateTime, string, int>> DataSet = new List<Tuple<int, DateTime, string, int>>();

        public MainForm(string str)
        {
            InitializeComponent();
            label2.Text = str;
            checkedListBox1.DrawItem += checkedListBox1_DrawItem;


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

            // This will change the ListBox behaviour, so you can customize the drawing of each item on the list.
            // The fixed mode makes every item on the list to have a fixed size. If you want each item having
            // a different size, you can use DrawMode.OwnerDrawVariable.
            checkedListBox1.DrawMode = DrawMode.OwnerDrawFixed;

            // Here we define the height of each item on your list.
            checkedListBox1.ItemHeight = 40;

            // Here i will just make an example data source, to emulate the control you are trying to reproduce.
            var dataSet = new List<Tuple<string, string>>();

            dataSet.Add(new Tuple<string, string>("5:30 PM - 6:00 PM", "11 avaliable rooms"));
            dataSet.Add(new Tuple<string, string>("6:00 PM - 6:30 PM", "12 available rooms"));

            checkedListBox1.DataSource = dataSet;




            //using (SqlConnection conn = new SqlConnection())
            //{
            //    conn.ConnectionString = "Data Source = HonkAppDataBase.mssql.somee.com;" + "Initial Catalog=HonkAppDataBase;" + "User id=cargoesbrr_SQLLogin_1;" + "Password=nchbzqmryy;";
            //    conn.Open();

            //    using (SqlCommand myQuery = new SqlCommand("SELECT * FROM Users;", conn))
            //    using (SqlDataReader myReader = myQuery.ExecuteReader())
            //    {
            //        while (myReader.Read())
            //        {
            //            var usr = new User();

            //            usr.User_ID = (int)myReader["User_Id"];
            //            usr.Email = (string)myReader["Email"];
            //            if(usr.Email == label2.Text)
            //            {
            //                user = usr;
            //            }
            //        }
            //    }

            //    using (SqlCommand myQuery = new SqlCommand("SELECT * FROM Tasks;", conn))
            //    using (SqlDataReader myReader = myQuery.ExecuteReader())
            //    {
            //        while (myReader.Read())
            //        {
            //            var task = new Task();

            //            task.Task_Id = (int)myReader["Task_Id"];
            //            task.User_Id = (int)myReader["Task_Id"];
            //            //task.Team_Id = (int)myReader["Team_Id"];/////подумать, как сделать так, чтобы записывался null
            //            task.Status_Id = (int)myReader["Status_Id"];
            //            task.Deadline = (DateTime)myReader["Deadline"];
            //            //task.Finished = (DateTime?)myReader["Finished"];
            //            //task.Description = (string)myReader["Description"];
            //            task.Name = (string)myReader["Name"];
            //            task.Everyday = (int)myReader["Everyday"];
            //            //if (task.User_Id == ) ;
            //            //&& task.Deadline == DateTime.Now
            //            if (task.User_Id == user.User_ID )
            //            {
            //                tasks.Add(task);
            //                DataSet.Add(new Tuple<int, DateTime, string, int>(task.Status_Id, task.Deadline, task.Name, task.Everyday));
            //            }

            //        }
            //    }
            //}



            //for (int i = 0; i < tasks.Count; i++)
            //{
            //    Task task = new Task();
            //    task = tasks[i];
            //    checkedListBox1.Items.Add(task.Name);
            //}

        }

        private void checkedListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // This variable will hold the color of the bottom text - the one saying the count of 
            // the avaliable rooms in your example.
            Brush roomsBrush;

            // Here we override the DrawItemEventArgs to change the color of the selected 
            // item background to one of our preference.
            // I changed to SystemColors.Control, to be more like the list you are trying to reproduce.
            // Also, as I see in your example, the font of the room text part is black colored when selected, and gray
            // colored when not selected. So, we are going to reproduce it as well, by setting the correct color
            // on our variable defined above.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds,
                    e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, SystemColors.Control);

                roomsBrush = Brushes.Black;
            }
            else
            {
                roomsBrush = Brushes.Gray;
            }

            // Looking more at your example, i noticed a gray line at the bottom of each item.
            // Lets reproduce that, too.
            var linePen = new Pen(SystemBrushes.Control);
            var lineStartPoint = new Point(e.Bounds.Left, e.Bounds.Height + e.Bounds.Top);
            var lineEndPoint = new Point(e.Bounds.Width, e.Bounds.Height + e.Bounds.Top);

            e.Graphics.DrawLine(linePen, lineStartPoint, lineEndPoint);

            // Command the event to draw the appropriate background of the item.
            e.DrawBackground();

            // Here you get the data item associated with the current item being drawed.
            var dataItem = checkedListBox1.Items[e.Index] as Tuple<string, string>;

            // Here we will format the font of the part corresponding to the Time text of your list item.
            // You can change to wathever you want - i defined it as a bold font.
            var timeFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);

            // Here you draw the time text on the top of the list item, using the format you defined.
            e.Graphics.DrawString(dataItem.Item1, timeFont, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 5);

            // Now we draw the avaliable rooms part. First we define our font.
            var roomsFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);

            // And, finally, we draw that text.
            e.Graphics.DrawString(dataItem.Item2, roomsFont, roomsBrush, e.Bounds.Left + 3, e.Bounds.Top + 18);
        }
    }
}
