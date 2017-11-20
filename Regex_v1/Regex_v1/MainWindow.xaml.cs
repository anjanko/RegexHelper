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
        List<Expander> expList;
        public int NrExpandera { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            expList = new List<Expander> { Exp1, Exp2, Exp3, Exp4 };
            BtnCreate.IsEnabled = false;

        }

        private void Exp_Expanded(object sender, RoutedEventArgs e)
        {
            Expander thisExpander = e.Source as Expander;
            foreach (Expander exp in expList)
            {
                if (exp == thisExpander)
                {
                    exp.IsExpanded = true;
                    exp.FontWeight = FontWeights.Bold;
                    NrExpandera = int.Parse(exp.Name.Substring(3));
                }
                else
                {
                    exp.IsExpanded = false;
                    exp.FontWeight = FontWeights.Normal;
                }
            }
            BtnCreate.IsEnabled = true;
            
        }

        private void Exp_Collapsed(object sender, RoutedEventArgs e)
        {
            BtnCreate.IsEnabled = false;
            foreach(Expander exp in expList)
            {
                exp.FontWeight = FontWeights.Normal;
            }
        }

        private void ex2_btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(ex2_textbox.Text))
            {
                return;
            }
            ex2_lista.Items.Add(ex2_textbox.Text);
            ex2_textbox.Text = String.Empty;
        }

        private void CheckIfEnter_ex2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ex2_btnAdd_Click(sender, e);
            }
        }

        private void ex2_btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(ex2_lista.SelectedItem!=null)
            {
                ex2_lista.Items.Remove(ex2_lista.SelectedItem);
                ex2_lista.UnselectAll();
            }
        }

        private void ex3_btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(ex3_textbox.Text))
            {
                return;
            }
            ex3_lista.Items.Add(ex3_textbox.Text);
            ex3_textbox.Text = String.Empty;
        }

        private void CheckIfEnter_ex3(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ex3_btnAdd_Click(sender, e);
            }
        }

        private void ex3_btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ex3_lista.SelectedItem != null)
            {
                ex3_lista.Items.Remove(ex3_lista.SelectedItem);
                ex3_lista.UnselectAll();
            }
        }
    }
}
