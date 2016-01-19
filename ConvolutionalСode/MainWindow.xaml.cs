using ConvolutionalСode.source;
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
using System.Text.RegularExpressions;

namespace ConvolutionalСode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //default values
            baseCode.BufferSize = 3;
            string[] generators = new string[] { "110", "101"};

            baseCode.FunctionalGenerators = generators;

            refreshCode();
        }
        source.BaseCode baseCode = new source.Nesystem();


        private void refreshCode()
        {
            txtBoxBuffer.Text = baseCode.BufferSize.ToString();
            txtBoxAdders.Text = baseCode.FunctionalGenerators.Length.ToString();

            lblCodeSpeed.Content = (1 / (double)baseCode.FunctionalGenerators.Length).ToString();

            listBoxGenerators.Items.Clear();

            foreach (string s in baseCode.FunctionalGenerators)
                listBoxGenerators.Items.Add(s);
 
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItemStatement_Click(object sender, RoutedEventArgs e)
        {
            SystemCodeWindow sWindow = new SystemCodeWindow();
            sWindow.ShowDialog();

        }

        private void MenuItemSpeciality_Click(object sender, RoutedEventArgs e)
        {
            UnsystemCodeWindow window = new UnsystemCodeWindow();
            window.ShowDialog();
        }

        private void MenuItemFaculty_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Свёрточные коды. ");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonCode_Copy_Click(object sender, RoutedEventArgs e)
        {
            textBox3.Text = (baseCode.Encode(textBox2.Text));

        }

        private void buttonCode_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if(textBox3.Text != "")
            textBox3_Copy.Text = UniversalDecoder.Decode(baseCode, textBox3.Text);

        }

        private void buttonCode_Copy2_Click(object sender, RoutedEventArgs e)
        {
            baseCode.BufferSize = Convert.ToInt16(txtBoxBuffer.Text);

            baseCode.FunctionalGenerators = null ;
            baseCode.FunctionalGenerators = new string[Convert.ToInt16(txtBoxAdders.Text)];

            try
            {
                for (int i = 0; i < Convert.ToInt16(txtBoxAdders.Text); i++)
                {
                    baseCode.FunctionalGenerators[i] = listBoxGenerators.Items[i].ToString();
                }
                refreshCode();
            }
            catch(Exception)
            {
                
                MessageBox.Show("Указанное количество генераторов больше количества значений генераторов! Введите доп. значения");
            }
        }

        private void listBoxGenerators_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
        {

        }

        private void listBoxGenerators_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listBoxGenerators.SelectedIndex >= 0)
            {
                DialogWindow dialog = new DialogWindow(listBoxGenerators);
                dialog.ShowDialog();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            listBoxGenerators.Items.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DialogAddWindow dialogAdd = new DialogAddWindow(listBoxGenerators);
            dialogAdd.ShowDialog();
        }
    }
}
