using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitManager.Classes.Data_and_Persistence
{
    interface IPersistenceSave
    {
        //Interface to save data to a given filePath
        void SaveData(string filePath);
    }
}
