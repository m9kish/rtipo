﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Views
{
    public interface IWorkWithMainForm
    {
        DataTable DataTable { get; set; }

        int Id { get; set; } 
    }
}
