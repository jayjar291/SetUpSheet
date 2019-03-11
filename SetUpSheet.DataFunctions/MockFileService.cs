using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SetUpSheet.Core;

namespace SetUpSheet.DataFunctions
{
    public class MockFileService : ILoadable
    {
        public List<ComboBox> comboBoxes()
        {
            throw new NotImplementedException();
        }

        public List<Employee> Load()
        {
            /* Mock file service*/
            return new List<Employee>()
            {
                new Employee("Jared", true, DateTime.Now.AddHours(-5), DateTime.Now)
            };
        }

        public List<Employee> LoadAdvanced()
        {
            throw new NotImplementedException();
        }
    }
}
