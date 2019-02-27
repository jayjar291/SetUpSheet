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
        Roster roster = new Roster();
        public Form1()
        {            
            InitializeComponent();
        }

        private void refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = roster.Employees;
            pnlLunch.Controls.Clear();
            int y = 3;
            foreach (var item in roster.Employees)
            {
                RosterControl temp = new RosterControl();
                temp.Location = new Point(3, y);
                temp.DataSource(item);
                pnlLunch.Controls.Add(temp);
                y += 33;
            }
        }

        private void bntLoad_Click(object sender, EventArgs e)
        {
            roster.LoadFile(ServiceLocator.GetEmployeePersistence("Production"));
            Load load = new Load(roster);
            load.ShowDialog();
            refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
    }
}
