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
            MenuCanvas.Visibility = Visibility.Hidden;

            GennemseMenu.Visibility = Visibility.Visible;
        }

        // Viser Private
        private void LookAtPrivateBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseWhatToLookAt.Visibility = Visibility.Hidden;

            GennemsePrivate.Visibility = Visibility.Visible;

            LookAtPrivate.Text = $"{middleClass.ReturnPrivateCustormers()}";
        }

        // Tilføjer En Regning til de private
        private void AddBillingForPrivate_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(pIDInputForBilling.Text);
            int custormerId = int.Parse(privateIdInputForBilling.Text);
            int hours = int.Parse(privateHoursInputForBilling.Text);

            middleClass.AddNewBilling(id, custormerId, hours);
        }

        // Tilføjer en regning til et firma

        private void AddBillingForCompany_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(CompanyIdInputForBilling.Text);
            int custormerId = int.Parse(cIDInputForBilling.Text);
            int hours = int.Parse(CompanyHoursInputForBilling.Text);

            middleClass.AddNewBilling(id, custormerId, hours);
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
            ChooseAdd.Visibility = Visibility.Hidden;

            AddCompany.Visibility = Visibility.Visible;
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
            string firstname = pFirstNameInput.Text;
            string lastname = pLastNameInput.Text;
            string address = pAddressInput.Text;
            int tlf = int.Parse(pTlfInput.Text);

            middleClass.AddNewPrivateCustormer(firstname, lastname, address, tlf);
        }

        // Tilføj et nyt firma
        private void addCompany_Click(object sender, RoutedEventArgs e)
        {
            string companyname = companyNameInput.Text;
            string senumber = seNummerInput.Text;
            int tlf = int.Parse(companyTlfInput.Text);

            middleClass.AddNewCompany(companyname, senumber, tlf);
        }

        private void LookAtCompanysBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseWhatToLookAt.Visibility = Visibility.Hidden;

            GennemseFirmaer.Visibility = Visibility.Visible;

            LookAtCompanys.Text = $"{middleClass.ReturnCompanys()}";
        }
    }
}
