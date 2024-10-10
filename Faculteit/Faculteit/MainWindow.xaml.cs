using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Faculteit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isNumber = Int32.TryParse(numberTextBox.Text, out int number);
            int result = 1;
            if (isNumber)
            {
                if (number >= 1)
                {
                    for (int i = number; i > 1; i--)
                    {
                        result *= i;
                    }
                }
                else
                {
                    MessageBox.Show("Getal moet positief zijn!", "Verkeerde ingave");
                    numberTextBox.Focus();
                    numberTextBox.SelectAll();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Geef een 'positief' getal in,\nklik daarna op 'Berekenen", "foutieve ingave");
                numberTextBox.Focus();
                numberTextBox.SelectAll(); 
                return;
            }

            resultTextBox.Text = result.ToString();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = "";
            numberTextBox.Text = "1";
            numberTextBox.Focus();
            numberTextBox.SelectAll();
        }
    }
}