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
        DataBase database = new DataBase(); 
        public MainForm()
        {
            InitializeComponent();
        }

        public void CreateColums()
        {
            
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            
        }

        private void RefreshDataGrid(DataGridView dgw)
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
            CreateColums();
            RefreshDataGrid(MainDataGridView);

        }
    }
}
