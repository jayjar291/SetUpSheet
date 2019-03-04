/*
 * Dev Jared Stapley
 * Date 2-27-19
 * Setup Sheet UI
 *  
 *  The main functions for the first Deliverable are:
 *  
 *  Load employees’ function
 *  manually add employee
 *  auto break times
 *  
 *  these functions are finished
 *  
 *  There are a bunch of unfinsshed functions that will be added in later Deliverables.
 *  */

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
    public partial class MainUi : Form
    {
        Roster roster = new Roster();
        public MainUi()
        {
            InitializeComponent();
        }
        private void PlaceControls(Employee employee)
        {
            RosterControl temp = new RosterControl(employee);
            lyPLunch.Controls.Add(temp);
            if (employee.ClockOutTime.TimeOfDay > new TimeSpan(14, 30, 0))
            {
                RosterControl temp2 = new RosterControl(employee);
                lyPTrans.Controls.Add(temp2);
            }
        }
        /*Refresh Data Sources*/
        private void refresh()
        {
            cboLeader.DataSource = null;
            cboLeader.DataSource = null;
            cboLeader.DataSource = roster.Employees.ToList();
            foreach (ComboBox item in pnlNames.Controls.OfType<ComboBox>())
            {
                item.DataSource = roster.Employees.ToList();
            }

        }
        /*load Functions*/
        private void munOpen_Click(object sender, EventArgs e)
        {
            try
            {
                roster.LoadFile(ServiceLocator.GetEmployeePersistence("Production"));
                Load load = new Load(roster);
                var result = load.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    roster.Employees.Clear();
                }
                foreach (var item in roster.Employees)
                {
                    PlaceControls(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh();
        }
        /*add Functions*/
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            if (addEmployee.noInput)
            {
            }
            else
            {
                Employee temp = new Employee(addEmployee.txtName.Text, addEmployee.IsMinor.Checked, DateTime.Parse(addEmployee.Clockintime.Text), DateTime.Parse(addEmployee.Clockoutime.Text));
                roster.AddEmployee(temp);
                PlaceControls(temp);
            }
            refresh();
        }
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            foreach (RosterControl item in lyPLunch.Controls.OfType<RosterControl>())
            {
                item.EditMode(true);
            }
            foreach (RosterControl item in pnlTransition.Controls.OfType<RosterControl>())
            {
                item.EditMode(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}