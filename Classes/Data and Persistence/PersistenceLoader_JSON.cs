using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProfitManager.Classes.Data_and_Persistence
{
    public class PersistenceLoader_JSON : IPersistenceLoad
    {
        static MainWindow window;

        public PersistenceLoader_JSON(MainWindow _window)
        {
            window = _window;
        }

        public void LoadData(string filePath)
        {
            //If the specified savefile exists, try to load the data from the file to the program in JSON Format
            try
            {
                if (File.Exists(filePath))
                {
                    using (System.IO.StreamReader file =
                    new System.IO.StreamReader(filePath, false))
                    {
                        PersistenceConverter converter = new PersistenceConverter();
                        converter.ConvertFromData(window, JsonConvert.DeserializeObject<SaveData>(file.ReadToEnd()));
                    }
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("The specified save file has no valid data. Please check your settings for a valid file!", "Error 666: File not valid", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                window.ResetText();
            }
        }
    }
}
