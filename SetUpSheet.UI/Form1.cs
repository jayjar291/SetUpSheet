using SetUpSheet.Core;
using SetUpSheet.DataFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetUpSheet.UI
{
    public partial class Form1 : Form
    {
        Roster roster;
        public Form1()
        {            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            if (addEmployee.noInput)
            {
                refresh();
            }
            else
            {
                Employee temp = new Employee(addEmployee.txtName.Text, addEmployee.IsMinor.Checked, DateTime.Parse(addEmployee.Clockintime.Text), DateTime.Parse(addEmployee.Clockoutime.Text));
                roster.AddEmployee(temp);
                refresh();
            }
        }
        private void refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = roster.Employees;
            rosterControl1.DataSource(roster.Employees[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roster = new Roster(ServiceLocator.GetEmployeePersistence("Production"));
            refresh();
        }
    }
}
