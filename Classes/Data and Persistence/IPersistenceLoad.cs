﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitManager.Classes.Data_and_Persistence
{
    interface IPersistenceLoad
    {
        //Interface to load data from a given filePath
        void LoadData(string filePath);
    }
}
