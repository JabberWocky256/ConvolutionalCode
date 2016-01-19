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
    /// Interaction logic for UnsystemCodeWindow.xaml
    /// </summary>
    public partial class UnsystemCodeWindow : Window
    {
        source.Nesystem unsystem = new source.Nesystem();

        public UnsystemCodeWindow()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonCode_Copy_Click(object sender, RoutedEventArgs e)
        {
            unsystem.BufferSize = 3;

            string[] generators = new string[] { "111", "100", "011"};
            textBox3.Text = (unsystem.Encode(generators, textBox2.Text));

            textBox3_Copy.Text = UniversalDecoder.Decode(unsystem, textBox3.Text);

           // MessageBox.Show(unsystem.Adder("110", "100").ToString());
            
        }
    }
}
