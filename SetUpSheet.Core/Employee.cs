using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetUpSheet.Core
{
    /*main Employee Class*/
    public class Employee
    {
        public string FName { get; set; }
        public bool IsMinor { get; set; }
        public DateTime ClockInTime { get; set; }
        public DateTime ClockOutTime { get; set; }
        public DateTime BrakeStartTime { get; set; }
        public int BrakeType { get; set; }
        public TimeSpan TotalHours { get; set; }
        public Employee(string fname, bool minor, DateTime clockin,DateTime clockout)
        {
            FName = fname;
            IsMinor = minor;
            ClockInTime = clockin;
            ClockOutTime = clockout;
            BrakeType = -1;
            GetTotalHours();
            BreakTime breakTime = new BreakTime(this);
        }
        private void GetTotalHours()
        {
            TotalHours = ClockOutTime - ClockInTime;
        }
        public override string ToString()
        {
            return FName;
        }
    }
}
