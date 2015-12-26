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
using System.Windows.Shapes;

namespace ConvolutionalСode
{


    /// <summary>
    /// Interaction logic for SystematicalWindow.xaml
    /// </summary>
    public partial class SystemCodeWindow : Window
    {

        ConvolutionalСode.source.System systematical = new ConvolutionalСode.source.System();


        public SystemCodeWindow()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox3.Text = systematical.Code(textBox2.Text);
        }

        private void textBox3_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox3_Copy.Text = systematical.DeCode(textBox3.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
