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
            
            int custormerId = int.Parse(privateIdInputForBilling.Text);
            int hours = int.Parse(privateHoursInputForBilling.Text);

            middleClass.AddNewPrivateBilling(custormerId, hours);

            MenuCanvas.Visibility = Visibility.Visible;
            GennemseMenu.Visibility = Visibility.Hidden;
            ChooseWhatToLookAt.Visibility = Visibility.Visible;
            GennemsePrivate.Visibility = Visibility.Hidden;
        }

        // Tilføjer en regning til et firma

        private void AddBillingForCompany_Click(object sender, RoutedEventArgs e)
        {
            int price = int.Parse(CompanyPriceInput.Text);
            int custormerId = int.Parse(CompanyIdInputForBilling.Text);
            int hours = int.Parse(CompanyHoursInputForBilling.Text);

            middleClass.AddNewCompanyBilling(custormerId, hours, price);


            MenuCanvas.Visibility = Visibility.Visible;
            GennemseMenu.Visibility = Visibility.Hidden;
            ChooseWhatToLookAt.Visibility = Visibility.Visible;
            GennemseFirmaer.Visibility = Visibility.Hidden;
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

            ChooseAdd.Visibility = Visibility.Visible;
            AddPrivate.Visibility = Visibility.Hidden;
            AddCanvasMenu.Visibility = Visibility.Hidden;
            MenuCanvas.Visibility = Visibility.Visible;
        }

        // Tilføj et nyt firma
        private void addCompany_Click(object sender, RoutedEventArgs e)
        {
            string companyname = companyNameInput.Text;
            string senumber = seNummerInput.Text;
            int tlf = int.Parse(companyTlfInput.Text);

            middleClass.AddNewCompany(companyname, senumber, tlf);
            ChooseAdd.Visibility = Visibility.Visible;
            AddCompany.Visibility = Visibility.Hidden;
            AddCanvasMenu.Visibility = Visibility.Hidden;
            MenuCanvas.Visibility = Visibility.Visible;
        }

        private void LookAtCompanysBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseWhatToLookAt.Visibility = Visibility.Hidden;

            GennemseFirmaer.Visibility = Visibility.Visible;

            LookAtCompanys.Text = $"{middleClass.ReturnCompanys()}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuCanvas.Visibility = Visibility.Visible;
            GennemseMenu.Visibility = Visibility.Hidden;
            ChooseWhatToLookAt.Visibility = Visibility.Visible;
            GennemseOrdere.Visibility = Visibility.Hidden;
        }

        private void LookAtAllOrderssBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseWhatToLookAt.Visibility = Visibility.Hidden;

            GennemseOrdere.Visibility = Visibility.Visible;

            LookAtOrders.Text = $"{middleClass.ReutrnOrders()}";
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseAdd.Visibility = Visibility.Hidden;
            AddOrder.Visibility = Visibility.Visible;

            ListOfOrders.Text = $"{middleClass.ReutrnOrders()}";
        }

        private void AddOrderInputBtn_Click(object sender, RoutedEventArgs e)
        {
            ChooseAdd.Visibility = Visibility.Visible;
            AddOrder.Visibility = Visibility.Hidden;
            AddCanvasMenu.Visibility = Visibility.Hidden;
            MenuCanvas.Visibility = Visibility.Visible;

            int custormerId = int.Parse(CustormerIDInput.Text);
            string orderAddress = AddressInput.Text;
            string date = DateInput.Text;
            string message = MessageInput.Text;
            int hours = int.Parse(HoursInput.Text);

            middleClass.AddNewOrder(custormerId, orderAddress, date, message, hours);
        }
    }
}
