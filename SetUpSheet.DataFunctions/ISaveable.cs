using SetUpSheet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetUpSheet.DataFunctions
{
    //save functions
    public interface ISaveable
    {
        void SaveLayout(List<ComboBox> controls, List<Employee> employees);
        void SaveEmployees(List<Employee> employees);
    }
}
