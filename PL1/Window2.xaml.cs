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
using Project01_7735_5114_dotNet5780;
using BL;
namespace PL1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
       
        public Window2()
        {

            //bl.AddHostingUnit(hostingUnit);
            InitializeComponent();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            
            foreach (var item in DS.DataSource.hostingUnits)
            {

                listBox1.Items.Add(Convert.ToString(item.HostingUnitName));
                listBox2.Items.Add(item.Area);
                listBox3.Items.Add(Convert.ToString(item.Type));
                listBox4.Items.Add(Convert.ToString(item.Garden));
                listBox5.Items.Add(Convert.ToString(item.pool));
                listBox6.Items.Add(Convert.ToString(item.SmokingArea));
                listBox7.Items.Add(Convert.ToString(item.accessible));
            }

            }

            private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

        
    }
