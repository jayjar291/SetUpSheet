using SetUpSheet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetUpSheet.DataFunctions
{
    /* Load Interface*/
    public interface ILoadable
    {
        List<Employee> Load();
        List<Employee> LoadAdvanced();
        List<int> comboBoxes();
    }
}
