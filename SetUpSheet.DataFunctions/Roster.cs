using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SetUpSheet.Core;

namespace SetUpSheet.DataFunctions
{
    public class Roster
    {
        public List<Employee> Employees { get; set; }
        public void LoadFile(ILoadable employeeService)
        {
            Employees = employeeService.Load();
        }
        public void AddEmployee(Employee emp)
        {
            if (Employees is null)
            {
                Employees = new List<Employee>();
            }
            Employees.Add(emp);
        }
    }
}
