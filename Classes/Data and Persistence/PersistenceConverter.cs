using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitManager.Classes.Data_and_Persistence
{
    class PersistenceConverter : IPersistenceConvert
    {
        public void ConvertFromData(MainWindow window, SaveData data) //Convert the SaveData to Information displayed in the MainWindow 
        {
            window.IncomeText.Text = data.incomeText;
            window.SpentText.Text = data.spentText;
            window.UpdateText();
        }

        public SaveData ConvertToData(MainWindow window) //Convert the information displayed in the MainWindow to SaveData and return it
        {
            SaveData data = new SaveData(window.IncomeText.Text, window.SpentText.Text);
            return data;
        }
    }
}
