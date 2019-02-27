using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetUpSheet.Core
{
    public class BreakTime
    {
        public BreakTime(Employee employee)
        {
            if (employee.IsMinor)
            {
                TimeSpan time = new TimeSpan(3, 0, 0);
                if (employee.TotalHours >= time)
                {
                    time = time.Add(new TimeSpan(2,0,0));
                    if (employee.TotalHours >= time)
                    {
                        TimeSpan breakSpan = new TimeSpan(employee.TotalHours.Ticks / 2);
                        employee.BrakeStartTime = employee.ClockInTime + breakSpan;
                        employee.BrakeType = 1;
                    }
                    else
                    {
                        TimeSpan breakSpan = new TimeSpan(employee.TotalHours.Ticks / 2);
                        employee.BrakeStartTime = employee.ClockInTime + breakSpan;
                        employee.BrakeType = 0;
                    }
                }
                else
                {
                    employee.BrakeType = -1;
                }
            }
            else
            {
                TimeSpan time = new TimeSpan(4, 0, 0);
                if (employee.TotalHours >= time)
                {
                    time = time.Add(new TimeSpan(4, 0, 0));
                    if (employee.TotalHours >= time)
                    {
                        TimeSpan breakSpan = new TimeSpan(employee.TotalHours.Ticks / 2);
                        employee.BrakeStartTime = employee.ClockInTime + breakSpan;
                        employee.BrakeType = 3;
                    }
                    else
                    {
                        TimeSpan breakSpan = new TimeSpan(employee.TotalHours.Ticks / 2);
                        employee.BrakeStartTime = employee.ClockInTime + breakSpan;
                        employee.BrakeType = 2;
                    }
                }
                else
                {
                    employee.BrakeType = -1;
                }
            }
        }
    }
}
