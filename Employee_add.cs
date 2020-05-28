using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pineapple
{
    public partial class Employee_add : Form
    {
        public LocalDatabaseDataSet DB { get; set; }
        public Employee_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee empl = new Employee()
            {
                Firstname = textBox1.Text,
                Lastname = textBox2.Text
            };
            //DB.Employee.AddEmployeeRow(empl);
        }
    }
}
