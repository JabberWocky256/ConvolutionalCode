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
            CatastrophicalCodeWindow window = new CatastrophicalCodeWindow();
            window.ShowDialog();
        }
    }
}
