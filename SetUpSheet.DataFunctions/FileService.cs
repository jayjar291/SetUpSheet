using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SetUpSheet.Core;
using System.Windows.Forms;

//data functions
namespace SetUpSheet.DataFunctions
{ 
    public class FileService : ILoadable,ISaveable
    {
        private string fileName;

        public FileService(string fileName)
        {
            this.fileName = fileName;
        }

        public List<ComboBox> comboBoxes()
        {
            throw new NotImplementedException();
        }

        /*load file in to list*/
        public List<Employee> Load()
        {
            FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(input);
            List<Employee> employees = new List<Employee>();

            while (!streamReader.EndOfStream)
            {
                var employee = streamReader.ReadLine();
                string[] split = employee.Split(',');
                Employee temp = new Employee(split[0], bool.Parse(split[1]), DateTime.Parse(split[2]), DateTime.Parse(split[3]));
                employees.Add(temp);
            }
            return employees;
        }

        public List<Employee> LoadAdvanced()
        {
            FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(input);
            List<Employee> employees = new List<Employee>();

            while (streamReader.ReadLine() != "~*~")
            {
                var employee = streamReader.ReadLine();
                string[] split = employee.Split(',');
                Employee temp = new Employee(split[0], bool.Parse(split[1]), DateTime.Parse(split[2]), DateTime.Parse(split[3]));
                employees.Add(temp);
            }
            return employees;
        }

        //save employees
        public void SaveEmployees(List<Employee> employees)
        {
            FileStream output = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(output);
            foreach (var item in employees)
            {
                streamWriter.WriteLine(item.ToFile());
                streamWriter.Flush();
            }
            output.Close();
        }
        //save Layout
        public void SaveLayout(List<ComboBox> controls, List<Employee> employees)
        {
            FileStream output = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(output);
            foreach (var item in employees)
            {
                streamWriter.WriteLine(item.ToFile());
                streamWriter.Flush();
            }
            streamWriter.WriteLine("~*~");
            foreach (var item in controls)
            {
                if (item.Text != "~*~")
                {
                    streamWriter.WriteLine(item.SelectedIndex);
                    streamWriter.Flush();
                }
                else
                {
                    streamWriter.WriteLine(item.Text);
                    streamWriter.Flush();
                }
            }
            output.Close();
        }
        private override Employee(string fname, bool minor, DateTime clockin, DateTime clockout, int breakType, DateTime breakStart,TimeSpan totalHours)
        {

        }
    }
}
