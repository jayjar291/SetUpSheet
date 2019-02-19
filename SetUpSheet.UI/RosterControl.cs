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
        public RosterControl()
        {
            InitializeComponent();
        }
        public  void DataSource(Employee employee)
        {
            txtName.Text = employee.FName;
            ckbIsMinor.Checked = employee.IsMinor;
            Clockin.Value = employee.ClockInTime;
            Clockout.Value = employee.ClockOutTime;
            switch (employee.BrakeType)
            {
                case -1:
                    {
                        txtbreakType.Text = "No Break";
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
        }
    }
}
