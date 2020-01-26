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

namespace PL1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL.BL_Impl bl;
        public MainWindow()
        {
            bl = new BL.BL_Impl();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addGuestRequest gr = new addGuestRequest();
            gr.Show(bl);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.ShowDialog();
        }
    }
}
