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
    /// Interaction logic for UCEdit_Type.xaml
    /// </summary>
    public partial class UCEdit_Type : UserControl
    {
        public UCEdit_Type(Grid UCGUIGrid)
        {
            InitializeComponent();
        }


        bool hasBeenClicked = false;
        private void Type_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
            hasBeenClicked = false;
        }

        private void SaveWriter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Decline_Click(object sender, RoutedEventArgs e)
        {
            ((Grid)Parent).Children.Remove(this);
        }
    }
}
