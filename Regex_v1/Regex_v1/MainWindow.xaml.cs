using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Regex_v1
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
        
        private void Chbx4_Click(object sender, RoutedEventArgs e)
        {
            Exp4.IsExpanded = Chbx4.IsChecked == true ? true : false;
        }

        private void Chbx3_Click(object sender, RoutedEventArgs e)
        {
            Exp3.IsExpanded = Chbx3.IsChecked == true ? true : false;
        }

        private void Chbx2_Click(object sender, RoutedEventArgs e)
        {
            Exp2.IsExpanded = Chbx2.IsChecked == true ? true : false;
        }

        private void Chbx1_Click(object sender, RoutedEventArgs e)
        {
            Exp1.IsExpanded = Chbx1.IsChecked == true ? true : false;
        }

        private void year_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex regex = new Regex("^[/d/d/d/d]$");    //nie działa prawidłowo
            MatchCollection matches1 = regex.Matches(year1.Text);
            MatchCollection matches2 = regex.Matches(year2.Text);

            if (matches1.Count != 1 || matches2.Count != 1)
            {
                lbl4digits.Visibility = Visibility.Visible;
                lblYearCompare.Visibility = Visibility.Hidden;
                btnDateOK.IsEnabled = false;
            }
            else
            {
                lbl4digits.Visibility = Visibility.Hidden;
                var year1text = int.Parse(year1.Text);
                var year2text = int.Parse(year2.Text);
                if(year1text>year2text)
                {
                    lblYearCompare.Visibility = Visibility.Visible;
                    btnDateOK.IsEnabled = false;
                }
                else
                {
                    lblYearCompare.Visibility = Visibility.Hidden;
                    btnDateOK.IsEnabled = true;
                }
            }
        }
    }
}
