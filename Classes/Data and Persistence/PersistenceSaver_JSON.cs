using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitManager.Classes.Data_and_Persistence
{
    public class PersistenceSaver_JSON : IPersistenceSave
    {
        static MainWindow window;
        public PersistenceSaver_JSON(MainWindow _window)
        {
            window = _window;
        }

        public void SaveData(string filePath)
        {
            //If the given path exists, save the data in JSON-Format
            if (filePath == String.Empty)
            {
                System.Windows.MessageBox.Show("No Savefile was specified. Data will not be saved");
            }
            else
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(filePath, false))
                {
                    PersistenceConverter converter = new PersistenceConverter();
                    file.Write(JsonConvert.SerializeObject(converter.ConvertToData(window)));
                }
            }
        }
    }
}
