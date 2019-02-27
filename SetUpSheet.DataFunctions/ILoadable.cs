﻿using SetUpSheet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetUpSheet.DataFunctions
{
    /* Load Interface*/
    public interface ILoadable
    {
        List<Employee> Load();
    }
}
