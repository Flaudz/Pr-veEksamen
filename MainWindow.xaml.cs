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

namespace PrøveEksamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MiddleClass middleClass = new MiddleClass();
        public MainWindow()
        {
            InitializeComponent();
        }

        // Viser de 3 mugeligheder for at vise de forskellige kunder
        private void GennemseBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        // Viser de 2 mugeligheder for at tilføje kunder
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuCanvas.Visibility = Visibility.Hidden;

            AddCanvasMenu.Visibility = Visibility.Visible;
        }

        // Vis formlen for at tilføje et firma som kunde
        private void AddCompanyBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        // Vis formlen for at tilføje en private kunde
        private void AddPrivateBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseAdd.Visibility = Visibility.Hidden;

            AddPrivate.Visibility = Visibility.Visible;
        }

        // Tilføj en private kunde
        private void addPCustormer_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(pIdInput.Text);
            string firstname = pFirstNameInput.Text;
            string lastname = pLastNameInput.Text;
            string address = pAddressInput.Text;
            int tlf = int.Parse(pTlfInput.Text);

            middleClass.AddNewPrivateCustormer(id, firstname, lastname, address, tlf);
        }
    }
}
