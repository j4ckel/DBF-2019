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

namespace GUI_DBF_2019_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UCGUI ucg = new UCGUI();
            UCLogin ulg = new UCLogin();
            //MainGrid.Children.Add(ucg);
            supGrid.Visibility = Visibility.Collapsed;
            MainGrid.Children.Add(ulg);
            gridRight.Children.Add(ucg);
        }
    }
}
