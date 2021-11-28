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
namespace Lab_7_1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Calculate(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearText();
                char[] SeparatorChars = { ' ' };
                string[] ArrayText = Data.Text.Split(SeparatorChars);

                List<double> ArrayDouble = new List<double>();
                foreach (string i in ArrayText)
                {
                    ArrayDouble.Add(double.Parse(i));
                }
                foreach (int i in ArrayDouble)
                {
                    if (i % 2 == 0) { }
                    else
                    {
                        UnpiredNumbers.Text += $"{i } ";
                    }
                }
                BiggestNumber.Text = ArrayDouble.Max().ToString();
                SmallestNumber.Text = ArrayDouble.Min().ToString();
                MiddleNumber.Text = ArrayDouble.Average().ToString();
                SumNumber.Text = ArrayDouble.Sum().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Уберіть лишні символи та літери","Помилка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
      

        }
        private void ClearText()
        {
            BiggestNumber.Text = "";
            SmallestNumber.Text = "";
            SumNumber.Text = "";
            MiddleNumber.Text = "";
            UnpiredNumbers.Text = "";
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Data.Text = "";
            ClearText();
        }
    }
}
