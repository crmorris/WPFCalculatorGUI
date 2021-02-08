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

namespace GUICalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBox.Text = "";
        }

        public int funcStore = 0;
        public double valueStore = 0;
        public bool flag = false;

        public void DoMath(int storedFunc, double storedValue)
        {
            if (storedFunc == 0)
            {
                //do nothing
            }
            else if (storedFunc == 1)
            {
                this.TextBox.Text = (this.valueStore + (double.Parse(this.TextBox.Text))).ToString();
            }
            else if (storedFunc == 2)
            {
                this.TextBox.Text = (this.valueStore - (double.Parse(this.TextBox.Text))).ToString();
            }
            else if (storedFunc == 3)
            {
                this.TextBox.Text = (this.valueStore * (double.Parse(this.TextBox.Text))).ToString();
            }
            else if (storedFunc == 4)
            {
                this.TextBox.Text = (this.valueStore / (double.Parse(this.TextBox.Text))).ToString();
            }
        }

        private void PercentageClick(object sender, RoutedEventArgs e)
        {
            double temp = double.Parse(this.TextBox.Text);
            this.TextBox.Text = (temp * 1 / 100).ToString();
        }
        private void SqRtClick(object sender, RoutedEventArgs e)
        {
            double temp = double.Parse(this.TextBox.Text);
            this.TextBox.Text = Math.Sqrt(temp).ToString();
        }
        private void PowerClick(object sender, RoutedEventArgs e)
        {
            double temp = double.Parse(this.TextBox.Text);
            this.TextBox.Text = Math.Pow(temp, 2).ToString();
        }
        private void FractionClick(object sender, RoutedEventArgs e)
        {
            double temp = double.Parse(this.TextBox.Text);
            this.TextBox.Text = (1 / temp).ToString();
        }
        private void CEClick(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text = "";
        }
        private void CClick(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text = "";
            this.valueStore = 0;
            this.funcStore = 0;
        }
        private void MysteryClick(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text = this.TextBox.Text.Remove(this.TextBox.Text.Length - 1, 1);
        }
        private void DivideClick(object sender, RoutedEventArgs e)
        {
            DoMath(this.funcStore, this.valueStore);
            this.funcStore = 4;
            this.valueStore = double.Parse(this.TextBox.Text);
            if (this.flag == true)
            {
                this.TextBox.Text = this.valueStore.ToString();
            }
            this.flag = true;
        }
        private void SevenClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "7";
            }
            else
            {
                this.TextBox.Text = "7";
                this.flag = false;
            }
        }
        private void EightClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "8";
            }
            else
            {
                this.TextBox.Text = "8";
                this.flag = false;
            }
        }
        private void NineClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "9";
            }
            else
            {
                this.TextBox.Text = "9";
                this.flag = false;
            }
        }
        private void MultiplyClick(object sender, RoutedEventArgs e)
        {
            DoMath(this.funcStore, this.valueStore);
            this.funcStore = 3;
            this.valueStore = double.Parse(this.TextBox.Text);
            if (this.flag == true)
            {
                this.TextBox.Text = this.valueStore.ToString();
            }
            this.flag = true;
        }
        private void FourClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "4";
            }
            else
            {
                this.TextBox.Text = "4";
                this.flag = false;
            }
        }
        private void FiveClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "5";
            }
            else
            {
                this.TextBox.Text = "5";
                this.flag = false;
            }
        }
        private void SixClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "6";
            }
            else
            {
                this.TextBox.Text = "6";
                this.flag = false;
            }
        }
        private void SubtractClick(object sender, RoutedEventArgs e)
        {
            DoMath(this.funcStore, this.valueStore);
            this.funcStore = 2;
            this.valueStore = double.Parse(this.TextBox.Text);
            if (this.flag == true)
            {
                this.TextBox.Text = this.valueStore.ToString();
            }
            this.flag = true;
        }
        private void OneClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "1";
            }
            else
            {
                this.TextBox.Text = "1";
                this.flag = false;
            }
        }
        private void TwoClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "2";
            }
            else
            {
                this.TextBox.Text = "2";
                this.flag = false;
            }
        }
        private void ThreeClick(object sender, RoutedEventArgs e)
        {
            if (this.flag == false)
            {
                this.TextBox.Text += "3";
            }
            else
            {
                this.TextBox.Text = "3";
                this.flag = false;
            }
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            DoMath(this.funcStore, this.valueStore);
            this.funcStore = 1;
            this.valueStore = double.Parse(this.TextBox.Text);
            if (this.flag == true)
            {
                this.TextBox.Text = this.valueStore.ToString();
            }
            this.flag = true;
        }
        private void NegClick(object sender, RoutedEventArgs e)
        {
            if ((!TextBox.Text.StartsWith("0")) && (TextBox.Text != ""))
            {
                double temp = double.Parse(this.TextBox.Text);
                this.TextBox.Text = (-1 * temp).ToString();
            }
            else
            {
                //do nothing
            }
        }
        private void ZeroClick(object sender, RoutedEventArgs e)
        {
            if (this.TextBox.Text == "0")
            {
                //do nothing
            }
            else
            {
                this.TextBox.Text += 0;
            }
        }
        private void PointClick(object sender, RoutedEventArgs e)
        {
            if (this.TextBox.Text == "")
            {
                this.TextBox.Text += "0.";
            }
            else if (this.TextBox.Text.Contains("."))
            {
                //do nothing
            }
            else
            {
                this.TextBox.Text += ".";
            }
        }
        private void EqualsClick(object sender, RoutedEventArgs e)
        {
            DoMath(this.funcStore, this.valueStore);
            this.funcStore = 0;
            if (this.flag == true)
            {
                this.TextBox.Text = this.valueStore.ToString();
            }
            this.valueStore = 0;
            this.flag = true;
        }
    }
}
