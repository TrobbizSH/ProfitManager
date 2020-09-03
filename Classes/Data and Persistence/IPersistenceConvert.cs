using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitManager.Classes.Data_and_Persistence
{
    interface IPersistenceConvert
    {
        //Interface to convert data to information displayed in the MainWindow and vice versa
        void ConvertFromData(MainWindow window, SaveData data);

        SaveData ConvertToData(MainWindow window);
    }
}
