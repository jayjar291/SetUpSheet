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
        StreamReader streamReaderadvance;
        FileStream inputadvanced;
        private List<int> nulldata = new List<int>();
        
        public FileService(string fileName)
        {
            this.fileName = fileName;
            for (int i = 0; i < 100; i++)
            {
                nulldata.Add(i);
            }
        }

        public List<int> comboBoxes()
        {
            List<int> index = new List<int>();
            while (!streamReaderadvance.EndOfStream)
            {
                var line = streamReaderadvance.ReadLine();
                if (line == "~*~")
                {
                    index.Add(-5);
                }
                else
                {
                    index.Add(int.Parse(line));
                }
            }
            return index;
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
                Employee temp = new Employee(split[0], bool.Parse(split[1]), DateTime.Parse(split[2]), DateTime.Parse(split[3]), true);
                employees.Add(temp);
            }
            return employees;
        }

        public List<Employee> LoadAdvanced()
        {
            inputadvanced = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            streamReaderadvance = new StreamReader(inputadvanced);
            List<Employee> employees = new List<Employee>();
            var employee = streamReaderadvance.ReadLine();
            while (employee != "~*~")
            {
                string[] split = employee.Split(',');
                Employee temp = new Employee(split[0], bool.Parse(split[1]), DateTime.Parse(split[2]), DateTime.Parse(split[3]));
                temp.BrakeStartTime = DateTime.Parse(split[5]);
                temp.BrakeType = int.Parse(split[4]);
                employees.Add(temp);
                employee = streamReaderadvance.ReadLine();
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
    }
}
