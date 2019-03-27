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
    /// Interaction logic for UCAddBook.xaml
    /// </summary>
    public partial class UCAddBook : UserControl
    {
        public UCAddBook(Grid grid)
        {
            InitializeComponent();
        }

        private void ISBN_Edit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_ISBN UCEditISBN = new UCEdit_ISBN(UCGUIGrid);
            ((Grid)Parent).Children.Add(UCEditISBN);
        }

        private void TitelEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_Titel UCEditTitel = new UCEdit_Titel(UCGUIGrid);
            ((Grid)Parent).Children.Add(UCEditTitel);

        }

        private void ReleasedateEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_Udgivelsesdato UCEditReleasedate = new UCEdit_Udgivelsesdato(UCGUIGrid);
            ((Grid)Parent).Children.Add(UCEditReleasedate);
        }

        private void ForfatterEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_Forfatter UCEditWriter = new UCEdit_Forfatter(UCGUIGrid);
            ((Grid)Parent).Children.Add(UCEditWriter);
        }

        private void ForlagEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_Forlag UCEditForlag = new UCEdit_Forlag(UCGUIGrid);
            ((Grid)Parent).Children.Add(UCEditForlag);
        }

        private void GenreEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_Genre UCEditGenre = new UCEdit_Genre(UCGUIGrid);
            ((Grid)Parent).Children.Add(UCEditGenre);
        }

        private void TypeEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_Type UCEditType = new UCEdit_Type(UCGUIGrid);
            ((Grid)Parent).Children.Add(UCEditType);
        }

        private void IndkøbEdit_Click(object sender, RoutedEventArgs e)
        {
            UCEdit_Indkøb UCEditIndkøb = new UCEdit_Indkøb(UCGUIGrid);
            ((Grid)Parent).Children.Add(UCEditIndkøb);
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            ((Grid)Parent).Children.Remove(this);

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
