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

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox3.Text = unsystem.Code(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox3_Copy.Text = unsystem.DeCode(textBox3.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
