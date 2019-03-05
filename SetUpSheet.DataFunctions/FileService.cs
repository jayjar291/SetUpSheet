﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SetUpSheet.Core;
using System.Windows.Forms;


namespace SetUpSheet.DataFunctions
{ 
    public class FileService : ILoadable,ISaveable
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
        //save employees
        public void SaveEmployees(List<Employee> employees)
        {
            FileStream output = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(output);
            foreach (var item in employees)
            {
                streamWriter.WriteLine(item.ToFile());
            }
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
            foreach (var item in controls)
            {
                streamWriter.WriteLine(item.SelectedIndex);
                streamWriter.Flush();
            }
            output.Close();
        }
    }
}
