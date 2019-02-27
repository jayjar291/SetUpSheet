using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetUpSheet.Core;

namespace SetUpSheet.DataFunctions
{
    public class MockFileService : ILoadable
    {
        public List<Employee> Load()
        {
            /* Mock file service*/
            return new List<Employee>()
            {
                new Employee("Jared", true, DateTime.Now.AddHours(-5), DateTime.Now)
            };
        }
    }
}
