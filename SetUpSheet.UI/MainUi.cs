﻿/*
 * Dev Jared Stapley
 * Date 2-27-19
 * Setup Sheet UI
 *  
 *  The main functions for the secound Deliverable are:
 *  
 *  save functions
 *  finnish ui
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
        //place controls
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
            Console.WriteLine("this will be added later :)");
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
            List<ComboBox> comboBoxes = new List<ComboBox>();
            comboBoxes.Add(cboLeader);
            comboBoxes.Add(cbotransleader);
            foreach (ComboBox item in pnlNames.Controls)
            {
                comboBoxes.Add(item);
            }
            foreach (ComboBox item in pnlSecondary.Controls)
            {
                comboBoxes.Add(item);
            }
            foreach (ComboBox item in pnltransnames.Controls)
            {
                comboBoxes.Add(item);
            }
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
        //todo add
        private void mnuRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("this will be added later :)");
        }
    }
}