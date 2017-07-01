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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller Control;

        public MainWindow()
        {
            InitializeComponent();
            Control = new Controller(this);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnZero_Click          (object sender, RoutedEventArgs e)  { Control.enteredValue("ZERO"); }

        private void btnOne_Click           (object sender, RoutedEventArgs e)  { Control.enteredValue("ONE"); }

        private void btnTwo_Click           (object sender, RoutedEventArgs e)  { Control.enteredValue("TWO"); }

        private void btnThree_Click         (object sender, RoutedEventArgs e)  { Control.enteredValue("THREE"); }

        private void btnFour_Click          (object sender, RoutedEventArgs e)  { Control.enteredValue("FOUR"); }

        private void btnFive_Click          (object sender, RoutedEventArgs e)  { Control.enteredValue("FIVE"); }

        private void btnSix_Click           (object sender, RoutedEventArgs e)  { Control.enteredValue("SIX"); }

        private void btnSeven_Click         (object sender, RoutedEventArgs e)  { Control.enteredValue("SEVEN"); }

        private void btnEight_Click         (object sender, RoutedEventArgs e)  { Control.enteredValue("EIGHT"); }

        private void btnNine_Click          (object sender, RoutedEventArgs e)  { Control.enteredValue("NINE"); }

        private void btnComma_Click         (object sender, RoutedEventArgs e)  { Control.enteredValue("COMMA"); }

        private void btnClearEntry_Click    (object sender, RoutedEventArgs e)  { Control.enteredValue("CLEAR_ENTRY"); }

        private void btnClear_Click         (object sender, RoutedEventArgs e)  { Control.enteredValue("CLEAR"); }

        private void btnPlus_Click          (object sender, RoutedEventArgs e)  { Control.enteredValue("PLUS"); }

        private void btnMinus_Click         (object sender, RoutedEventArgs e)  { Control.enteredValue("MINUS"); }

        private void btnMultBy_Click        (object sender, RoutedEventArgs e)  { Control.enteredValue("MULTIPLIED"); }

        private void btnDivBy_Click         (object sender, RoutedEventArgs e)  { Control.enteredValue("DIVIDED"); }

        private void btnEquals_Click        (object sender, RoutedEventArgs e)  { Control.enteredValue("EQUALS"); }
    }
}
