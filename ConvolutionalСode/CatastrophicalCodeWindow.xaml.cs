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
    /// Interaction logic for CatastrophicalCodeWindow.xaml
    /// </summary>
    public partial class CatastrophicalCodeWindow : Window
    {

        source.Catostrophycal catastrophical = new source.Catostrophycal();
        public CatastrophicalCodeWindow()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox3.Text = catastrophical.Code(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(textBox3.Text.Length > 4)
            textBox3_Copy.Text = catastrophical.DeCode(textBox3.Text.Substring(4));

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
