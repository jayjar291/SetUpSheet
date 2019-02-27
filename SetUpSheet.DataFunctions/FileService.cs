using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SetUpSheet.Core;

namespace SetUpSheet.DataFunctions
{ 
    public class FileService : ILoadable
    {
        private string fileName;

        public FileService(string fileName)
        {
            this.fileName = fileName;
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
    }
}
