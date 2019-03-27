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
using BIZ_DBF_2019_;
using REPO_DBF_2019_;

namespace GUI_DBF_2019_
{
    /// <summary>
    /// Interaction logic for UserControlListView.xaml
    /// </summary>
    public partial class UserControlListView : UserControl
    {
        Grid MainLeftGrid;
        ClassBiz _CB;
        public UserControlListView(ClassBiz inClass, Grid gridLeft)
        {
            InitializeComponent();
            _CB = inClass;   
            MainLeftGrid = gridLeft;

            GridMain.DataContext = _CB;
        }

        private void ListViewBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            _CB.bog = null;
            ListView LV = (ListView)sender;
            _CB.bog = (ClassBog)LV.SelectedItem;
        }
    }
}
