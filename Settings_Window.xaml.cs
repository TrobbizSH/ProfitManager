using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Microsoft.Win32;
using ProfitManager.Classes.Metadata;

namespace ProfitManager
{
    /// <summary>
    /// Interaktionslogik für Settings_Window.xaml
    /// </summary>
    public partial class Settings_Window : Window
    {
        private MainWindow window;
        public Settings_Window(MainWindow _window)
        {
            window = _window;
            InitializeComponent();
            txtbox_path.Text = window.mdhandler.GetMetaData(MetaDataHandler.GetMetaFile(MetaDataHandler.MetaFiles.SaveFile));
        }

        private void btn_path_Click(object sender, RoutedEventArgs e)
        {
            //Prompts the user to choose (or to create) a txt file to save
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text files (*.txt)|*.txt";
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (fd.ShowDialog() == true)
            {
                txtbox_path.Text = fd.FileName;
            }
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            window.mdhandler.SetMetaData(MetaDataHandler.GetMetaFile(MetaDataHandler.MetaFiles.SaveFile), txtbox_path.Text);
            this.Close();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
