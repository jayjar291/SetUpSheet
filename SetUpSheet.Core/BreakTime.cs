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
                    time.Add(TimeSpan.FromHours(2));
                    if (employee.TotalHours >= time)
                    {
                        employee.BrakeStartTime = new DateTime(employee.TotalHours.Ticks / 2);
                        employee.BrakeType = 1;
                    }
                    employee.BrakeStartTime = new DateTime(employee.TotalHours.Ticks / 2);
                    employee.BrakeType = 0;
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
                    time.Add(TimeSpan.FromHours(4));
                    if (employee.TotalHours >= time)
                    {
                        employee.BrakeStartTime = new DateTime(employee.TotalHours.Ticks / 2);
                        employee.BrakeType = 3;
                    }
                    employee.BrakeStartTime = new DateTime(employee.TotalHours.Ticks / 2);
                    employee.BrakeType = 2;
                }
                else
                {
                    employee.BrakeType = -1;
                }
            }
        }
    }
}
