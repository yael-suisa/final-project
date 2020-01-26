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

namespace PL1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        BL.BL_Impl bl1;

        public Window1()
        {
            InitializeComponent();
        }
        
        
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            foreach (object item in bl1.GetAllOrders()) ;
             listbox1.AddHandler(I)
        }
    }
}
