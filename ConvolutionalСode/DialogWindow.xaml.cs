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

namespace ConvolutionalСode
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        string generatorValue = "";

        ListBox collection;

        public DialogWindow(ListBox generators)
        {
            InitializeComponent();
            collection = generators;
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonCode_Copy1_Click(object sender, RoutedEventArgs e)
        {
            collection.Items[collection.SelectedIndex] = txtResult.Text;
            //collection.Items.Add(txtResult.Text);
            this.Close();
        }
    }
}
