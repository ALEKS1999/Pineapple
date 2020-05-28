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

namespace Pineapple
{
    public partial class Form1 : Form
    {
        public LocalDatabaseDataSet DB { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    string connectionString;
        //    SqlConnection cnn;
        //    connectionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
        //    cnn = new SqlConnection(connectionString);
        //    cnn.Open();
        //    cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB = new LocalDatabaseDataSet();
            dataGridView1.DataSource = DB.Employee ;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Должность";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.TabIndex == 1)
            {
                Employee_add addForm = new Employee_add();
                addForm.DB = this.DB;
                addForm.ShowDialog();
                dataGridView1.DataSource = DB.Employee;

            } 
        }
    }
}
