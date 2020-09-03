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

namespace ProfitManager
{
    /// <summary>
    /// Interaktionslogik für InputBox.xaml
    /// </summary>
    public partial class InputBox : Window
    {
        MainWindow parent = null; //ParentObject for this inputwindow
        bool isIncome; //Boolean to get if the input window is for income or for spent money

        //Constructor to use from a MainWindowclass
        public InputBox(MainWindow _parent, bool _isIncome)
        {
            parent = _parent;
            isIncome = _isIncome;
            InitializeComponent();
            InputTextBox.IsEnabled = false; //Disable the textbox to block unwanted input
            Lb_Amount.Foreground = isIncome ? Brushes.Green : Brushes.Red; //Depending on income or spent money, make the "Amount label" green or red
            InputTextBox.IsEnabled = true; //Reenable the textbox
            InputTextBox.Focus();
            this.KeyDown += new KeyEventHandler(InputBox_KeyDown); //Registering a KeyEventHandler to listen for Keypresses
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBox.Text == String.Empty) return; //Abort if there is no input
            try
            {
                //Try to get the absolute value from the input field
                double inputSum =  Math.Abs(double.Parse(InputTextBox.Text));

                //Depending on the type of input, increase income or spent money on main window
                if (isIncome)
                    parent.IncomeText.Text = (double.Parse(parent.IncomeText.Text) + inputSum).ToString("0.00");
                else
                    parent.SpentText.Text = (double.Parse(parent.SpentText.Text) - inputSum).ToString("0.00");

                parent.UpdateText();
                this.Close();
            } catch
            {
                //If the user gave wrong input, tell him how to make correct input
                MessageBox.Show("The given input is not a correct amount. Please only use numbers and one point or comma!","Error!",MessageBoxButton.OK,MessageBoxImage.Error);
                InputTextBox.Clear();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //Close the window without writing data back
            this.Close();
        }

        void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape:
                    CancelButton_Click(null, null);
                    break;
            }
        }
    }
}
