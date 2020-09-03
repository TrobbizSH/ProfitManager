using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using ProfitManager.Classes.Data_and_Persistence;
using ProfitManager.Classes.Metadata;

namespace ProfitManager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //A class to load data in JSON and one to save data in JSON
        public MetaDataHandler mdhandler;
        public PersistenceLoader_JSON loader;
        public PersistenceSaver_JSON saver;

        public MainWindow()
        {
            //Check the metadata and if necessary, create the folder
            mdhandler = new MetaDataHandler();
            mdhandler.CreateMetaDataDirectory();

            //Handler to load and save the data
            loader = new PersistenceLoader_JSON(this);
            saver = new PersistenceSaver_JSON(this);
            InitializeComponent();
            loader.LoadData(mdhandler.GetMetaData(MetaDataHandler.GetMetaFile(MetaDataHandler.MetaFiles.SaveFile)));
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown); //Registering a KeyEventHandler to listen for Keypresses
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            ShowInputWindow(true);
        }

        public void UpdateText()
        {
            TotalText.Text = (double.Parse(IncomeText.Text) + double.Parse(SpentText.Text)).ToString("0.00");
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            ShowInputWindow(false);
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        { //Listen for + and - presses and start the corresponding input action
            switch (e.Key)
            {
                case Key.OemPlus: 
                    ShowInputWindow(true); break;
                case Key.OemMinus:
                    ShowInputWindow(false); break;
            }
        }

        void ShowInputWindow(bool isIncome)
        {
            InputBox box = new InputBox(this, isIncome);
            box.Show();
        }

        void Window_Closing(object sender, CancelEventArgs e)
        {
            saver.SaveData(mdhandler.GetMetaData(MetaDataHandler.GetMetaFile(MetaDataHandler.MetaFiles.SaveFile)));
        }

        public void ResetText()
        {
            //A Method to set the texts shown back to their default
            IncomeText.Text = "0,00";
            SpentText.Text = "0,00";
            TotalText.Text = "0,00";
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Settings_Window sw = new Settings_Window(this);
            sw.Show();
        }
    }
}
