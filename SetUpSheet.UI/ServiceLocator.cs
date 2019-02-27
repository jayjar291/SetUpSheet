using SetUpSheet.DataFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetUpSheet.UI
{
    public static class ServiceLocator
    {
        public static ILoadable GetEmployeePersistence(string source)
        {
            switch (source)
            {
                case "Production":
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    var result = openFile.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        return new FileService(openFile.FileName);
                    }
                    else
                    {
                        throw new Exception("Could not find file.");
                    }
                case "Development":
                    return new MockFileService();
                default:
                    return new MockFileService();
            }
        }
    }
}
