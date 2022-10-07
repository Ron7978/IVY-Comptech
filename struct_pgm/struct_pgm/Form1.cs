using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struct_pgm
{
    public partial class Form1 : Form
    {
        public struct EmployeeRecord
        {
            public string EmpName, Doj;
            public int salary;
            public EmployeeRecord(string name, string date, int sal)
            {
                EmpName = name;
                Doj = date;
                salary=sal;
            }

            public void ShowEmployeeDetails()
            {
                MessageBox.Show("Employee Name : " + EmpName);
                MessageBox.Show("Date of Joining : " + Doj);
                MessageBox.Show("Salary : " + salary);
            }

             
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeRecord record = new EmployeeRecord("Rounak", "20", 50000);
            record.ShowEmployeeDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeRecord record1 = new EmployeeRecord("Soham", "23", 35000);
            record1.ShowEmployeeDetails();
        }
    }
}
