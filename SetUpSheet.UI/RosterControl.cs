using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SetUpSheet.Core;

namespace SetUpSheet.UI
{
    public partial class RosterControl : UserControl
    {
        private Employee Employee;
        public RosterControl(Employee employee)
        {
            Employee = employee;
            InitializeComponent();
            txtName.Text = employee.FName;
            ckbIsMinor.Checked = employee.IsMinor;
            Clockin.Value = employee.ClockInTime;
            Clockout.Value = employee.ClockOutTime;
            switch (employee.BrakeType)
            {
                case -1:
                    {
                        txtbreakType.Text = "No Break";
                        BreakTime.Value = new DateTime(1999,12,31,0,0,0);
                    }
                    break;
                case 0:
                    {
                        BreakTime.Value = employee.BrakeStartTime;
                        txtbreakType.Text = "10";
                    }
                    break;
                case 1:
                    {
                        BreakTime.Value = employee.BrakeStartTime;
                        txtbreakType.Text = "30";
                    }
                    break;
                case 2:
                    {
                        BreakTime.Value = employee.BrakeStartTime;
                        txtbreakType.Text = "15";
                    }
                    break;
                case 3:
                    {
                        BreakTime.Value = employee.BrakeStartTime;
                        txtbreakType.Text = "30";
                    }
                    break;
                default:
                    break;
            }
            RunMode();
        }

        public void EditMode(bool mode)
        {
            if (mode)
            {
                foreach (Control item in Controls)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (Control item in Controls)
                {
                    item.Enabled = false;
                }
            }
        }

        private void BreakTime_ValueChanged(object sender, EventArgs e)
        {
            Employee.BrakeStartTime = BreakTime.Value;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Employee.FName = txtName.Text;
        }

        private void ckbIsMinor_CheckedChanged(object sender, EventArgs e)
        {
            Employee.IsMinor = ckbIsMinor.Checked;
            BreakTime breakTime = new BreakTime(Employee);
        }

        private void Clockin_ValueChanged(object sender, EventArgs e)
        {
            Employee.ClockInTime = Clockin.Value;
        }

        private void Clockout_ValueChanged(object sender, EventArgs e)
        {
            Employee.ClockOutTime = Clockout.Value;
        }
        public void RunMode()
        {
            if (DateTime.Now >= Clockin.Value.AddMinutes(-15))
            {
                incator1.BackColor = Color.Orange;
                if (DateTime.Now >= Clockin.Value)
                {
                    incator1.BackColor = Color.Green;
                    if (Employee.BrakeType == -1)
                    {
                        if (DateTime.Now >= Clockout.Value.AddMinutes(-15))
                        {
                            incator2.BackColor = Color.Orange;
                            if (DateTime.Now >= Clockout.Value)
                            {
                                incator2.BackColor = Color.Blue;
                                incator1.BackColor = SystemColors.Control;
                            }
                        }
                    }
                    else
                    {
                        if (DateTime.Now >= BreakTime.Value.AddMinutes(-15))
                        {
                            incator3.BackColor = Color.Orange;
                            if (DateTime.Now >= BreakTime.Value)
                            {
                                incator3.BackColor = Color.Green;
                                if (DateTime.Now >= BreakTime.Value.AddMinutes(int.Parse(txtbreakType.Text)))
                                {
                                    incator3.BackColor = Color.Blue;
                                    if (DateTime.Now >= Clockout.Value.AddMinutes(-15))
                                    {
                                        incator2.BackColor = Color.Orange;
                                        if (DateTime.Now >= Clockout.Value)
                                        {
                                            incator2.BackColor = Color.Blue;
                                            incator1.BackColor = SystemColors.Control;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
