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
                    openFile.ShowDialog();
                    return new FileService(openFile.FileName);
                case "Development":
                    return new MockFileService();
                default:
                    return new MockFileService();
            }
        }
    }
}
