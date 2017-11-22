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
//using System.Windows.Forms;

namespace Regex_v1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Expander> expList;
        List<string> Ex1_TokensList;
        List<string> Ex2_List;
        List<string> Ex3_List_notAllowed;
        private int Ex4_format;
        private int Ex4_searchOption;
        internal int NrExpandera;
        public MainWindow()
        {
            InitializeComponent();
            expList = new List<Expander> { Exp1, Exp2, Exp3, Exp4, Exp5 };
            BtnCreate.IsEnabled = false;
            Ex1_TokensList = new List<string>();
            Ex2_List = new List<string>();
            Ex3_List_notAllowed = new List<string>();
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
            ExpanderChanged();
        }

        private void ExpanderChanged()
        {
            TxtCreateResult.Text = string.Empty;
            ImgCopy.Visibility = Visibility.Collapsed;
            ImgRamka.Visibility = Visibility.Collapsed;

        }

        private void Exp_Collapsed(object sender, RoutedEventArgs e)
        {
            BtnCreate.IsEnabled = false;
            foreach(Expander exp in expList)
            {
                exp.FontWeight = FontWeights.Normal;
            }
            ExpanderChanged();

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

        private void CheckIfEnter_ex2(object sender, System.Windows.Input.KeyEventArgs e)
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

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            string result;
            CollectExpanderData(NrExpandera);
            switch (NrExpandera)
            {
                case 1:
                    result = RegexConverter.Exp1_Pattern(Ex1_TokensList);
                    break;
                case 2:
                    result = RegexConverter.Exp2_Words(Ex2_List);
                    break;
                case 3:
                    result = RegexConverter.Exp3_NotAllowed(Ex3_List_notAllowed);
                    break;
                case 4:
                    result = RegexConverter.Exp4_Date(Ex4_format, Ex4_searchOption);
                    break;
                case 5:
                    result = RegexConverter.Exp5_Email();
                    break;
                default:
                    result = string.Empty;
                    break;
            }
            TxtCreateResult.Text = result;
            ImgCopy.Visibility = Visibility.Visible;
        }

        private void CollectExpanderData(int nrExpandera)
        {
            switch(nrExpandera)
            {
                case 1:
                    break;
                case 2:
                    bool alreadyOnList;
                    Ex2_List.Clear();
                    foreach(var item in ex2_lista.Items)
                    {
                        alreadyOnList = false;
                        foreach (var pozycja in Ex2_List)
                        {
                            if(pozycja.Equals(item.ToString()))
                            {
                                alreadyOnList = true;
                                break;
                            }
                        }
                        if(!alreadyOnList)
                        {
                            Ex2_List.Add(item.ToString());
                        }
                    }
                    break;
                case 3:
                    bool _alreadyOnList;
                    Ex3_List_notAllowed.Clear();
                    foreach (var item in ex3_lista.Items)
                    {
                        _alreadyOnList = false;
                        foreach (var pozycja in Ex3_List_notAllowed)
                        {
                            if (pozycja.Equals(item.ToString()))
                            {
                                _alreadyOnList = true;
                                break;
                            }
                        }
                        if (!_alreadyOnList)
                        {
                            Ex3_List_notAllowed.Add(item.ToString());
                        }
                    }
                    break;
                case 4:
                    Ex4_format = ex4_rbDD.IsChecked == true ? 0 : 1;
                    Ex4_searchOption = ex4_rbTylkoData.IsChecked == true ? 0 : 1;
                    break;
                default:
                    break;
            }
            
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.Message);
        }

        private void ImgCopy_Click(object sender, MouseButtonEventArgs e)
        {
            ImgRamka.Visibility = Visibility.Visible;
            Clipboard.SetText(TxtCreateResult.Text);
        }

        //create po kliknięciu zamienia się na TEST IT, nowy event handler do przycisku
        //TEST IT: nowe okno, gdzie pisze się ciąg znaków testowych, a regex match sprawdza czy się zgadza
        //+ funckje case sensitive itp.
    }
}
