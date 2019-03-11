/*
 * Dev Jared Stapley
 * Date 3-8-19
 * Setup Sheet UI
 *  
 *  The main functions for the third Deliverable are:
 *  
 *  alert functions
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
using System.Threading;
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
        //place controls
        private void PlaceControls(Employee employee)
        {
            RosterControl temp = new RosterControl(employee);
            temp.MouseDown += new MouseEventHandler(SetNotes);
            lyPLunch.Controls.Add(temp);
            if (employee.ClockOutTime.TimeOfDay > new TimeSpan(14, 30, 0))
            {
                RosterControl temp2 = new RosterControl(employee);
                temp2.MouseDown += new MouseEventHandler(SetNotes);
                lyPTrans.Controls.Add(temp2);
            }
        }
        /*Refresh Data Sources*/
        private void refresh()
        {
            cbotransleader.DataSource = roster.Employees.ToList();
            cboLeader.DataSource = roster.Employees.ToList();
            foreach (ComboBox item in pnlNames.Controls.OfType<ComboBox>())
            {
                item.DataSource = roster.Employees.ToList();
            }
            foreach (ComboBox item in pnltransnames.Controls.OfType<ComboBox>())
            {
                item.DataSource = roster.Employees.ToList();

            }
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
        //edit mode
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            if (mnuEdit.Checked)
            {
                foreach (RosterControl item in lyPLunch.Controls.OfType<RosterControl>())
                {
                    item.EditMode(true);
                }
                foreach (RosterControl item in lyPTrans.Controls.OfType<RosterControl>())
                {
                    item.EditMode(true);
                }
                mnuEdit.Text = "Save Edits";
            }
            else
            {
                foreach (RosterControl item in lyPLunch.Controls.OfType<RosterControl>())
                {
                    item.EditMode(false);
                }
                foreach (RosterControl item in lyPTrans.Controls.OfType<RosterControl>())
                {
                    item.EditMode(false);
                }
                refresh();
            }
        }
        //load employees
        private void importEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
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
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //todo add
        private void layoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Layout files (*.ssl)|*.ssl|All files (*.*)|*.*";
                var result = openFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ILoadable loadable = new FileService(openFile.FileName);
                    roster.Loadlayout(loadable);
                    foreach (var item in roster.Employees)
                    {
                        PlaceControls(item);
                    }

                    refresh();
                }
                else
                {
                    throw new InvalidProgramException("Could not find file.");
                }
            }
            catch (InvalidProgramException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //save employees
        private void exportEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                var result = saveFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ISaveable saveable = new FileService(saveFile.FileName);
                    saveable.SaveEmployees(roster.Employees);
                }
                else
                {
                    throw new Exception("Could not find file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //save layout
        private void saveLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox spacer = new ComboBox() { Text = "~*~"};
            List<ComboBox> comboBoxes = new List<ComboBox>();
            comboBoxes.Add(cboLeader);
            comboBoxes.Add(cbotransleader);
            comboBoxes.Add(spacer);
            foreach (ComboBox item in pnlNames.Controls)
            {
                comboBoxes.Add(item);
            }
            comboBoxes.Add(spacer);
            foreach (ComboBox item in pnlSecondary.Controls)
            {
                comboBoxes.Add(item);
            }
            comboBoxes.Add(spacer);
            foreach (ComboBox item in pnltransnames.Controls)
            {
                comboBoxes.Add(item);
            }
            comboBoxes.Add(spacer);
            try
            {

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Layout files (*.ssl)|*.ssl|All files (*.*)|*.*";
                var result = saveFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ISaveable saveable = new FileService(saveFile.FileName);
                    saveable.SaveLayout(comboBoxes, roster.Employees);
                }
                else
                {
                    throw new Exception("Could not find file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //set notes
        private void SetNotes(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Notes notes = new Notes();
                var output = notes.ShowDialog();
                if (output == DialogResult.OK)
                {
                    tooltipservice.SetToolTip((Control)sender, notes.txtNotes.Text);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblUiClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            foreach (RosterControl item in lyPLunch.Controls.OfType<RosterControl>())
            {
                item.RunMode();
            }
            foreach (RosterControl item in lyPTrans.Controls.OfType<RosterControl>())
            {
                item.RunMode();
            }
        }
    }
}