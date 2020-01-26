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
using Project01_7735_5114_dotNet5780;

namespace UI
{
    /// <summary>
    /// Interaction logic for addGuestReqestWnd.xaml
    /// </summary>
    public partial class addGuestReqestWnd : Window
    {
        public addGuestReqestWnd()
        {
            InitializeComponent();
            foreach (var n in Enum.GetNames(typeof(enum_s.Status)))
                StatusCmb.Items.Add(n);

            foreach (var n in Enum.GetNames(typeof(enum_s.Area)))
                areaCmb.Items.Add(n);

            foreach (var n in Enum.GetNames(typeof(enum_s.Type)))
                TypeCmb.Items.Add(n);

            foreach (var n in Enum.GetNames(typeof(enum_s.Status)))
                StatusCmb.Items.Add(n);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
