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
        public TimeSpan TotalHours => ClockOutTime - ClockInTime;
        public Employee(string fname, bool minor, DateTime clockin,DateTime clockout, bool standerd = false)
        {
            FName = fname;
            IsMinor = minor;
            ClockInTime = clockin;
            ClockOutTime = clockout;
            if (standerd)
            {
                BrakeType = -1;
                BreakTime breakTime = new BreakTime(this);
            }
        }
        public override string ToString()
        {
            return FName;
        }
        //to file
        public string ToFile()
        {
            string temp = $"{FName},{IsMinor},{ClockInTime.ToLongTimeString()},{ClockOutTime.ToLongTimeString()},{BrakeType},{BrakeStartTime.ToLongTimeString()}";
            return temp;
        }
    }
}
