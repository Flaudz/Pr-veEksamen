using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PrøveEksamen
{
    public class MiddleClass
    {
        CleanITDataBase cleanDB = new CleanITDataBase();
        List<PrivateCustormer> privateCustormers = new List<PrivateCustormer>();
        List<Company> companies = new List<Company>();
        List<Billing> billings = new List<Billing>();
        List<AllCustormers> custormers = new List<AllCustormers>();
        List<Order> orders = new List<Order>();
        public List<PrivateCustormer> PrivateCustormers { get => privateCustormers; set => privateCustormers = value; }
        public List<Company> Companies { get => companies; set => companies = value; }
        public List<Billing> Billings { get => billings; set => billings = value; }
        public List<AllCustormers> Custormers { get => custormers; set => custormers = value; }
        public List<Order> Orders { get => orders; set => orders = value; }

        public void AddNewCompany(string companyname, string senumber, int tlf)
        {
            custormers = cleanDB.GetAllCustormers();
            companies = cleanDB.GetCompanys();
            int i = 0;
            foreach (AllCustormers item in custormers)
            {
                i++;
            }
            Company company = new Company(i+1, companyname, senumber, tlf);
            cleanDB.AddNewCompany(company);
            AllCustormers allCustormers = new AllCustormers(i + 1, "Company");
            cleanDB.AddAllCustormers(allCustormers);
        }

        public void AddNewPrivateCustormer(string firstname, string lastname, string address, int tlf)
        {
            custormers = cleanDB.GetAllCustormers();
            privateCustormers = cleanDB.GetPrivateCustormers();
            int i = 0;
            foreach (AllCustormers item in custormers)
            {
                i++;
            }
            PrivateCustormer custormer = new PrivateCustormer(i+1, firstname, lastname, address, tlf);
            cleanDB.AddNewPrivateCustormer(custormer);
            AllCustormers allCustormers = new AllCustormers(i + 1, "Private");
            cleanDB.AddAllCustormers(allCustormers);
        }


        // Billings
        public void AddNewPrivateBilling(int Custormerid, int hours)
        {
            billings = cleanDB.GetBillings();
            int i = 0;
            foreach (Billing bill in billings)
            {
                i++;
            }
            Billing billing = new Billing();
            billing.Id = i+1;
            billing.Custormerid = Custormerid;
            billing.Hours = hours;
            billing.Price = hours * 150;
            cleanDB.AddNewPrivateBilling(billing);
        }

        public void AddNewCompanyBilling(int Custormerid, int hours, int price)
        {
            billings = cleanDB.GetBillings();
            int i = 0;
            foreach (Billing bill in billings)
            {
                i++;
            }
            Billing billing = new Billing();
            billing.Id = i+1;
            billing.Custormerid = Custormerid;
            billing.Hours = hours;
            billing.Price = price;
            cleanDB.AddNewPrivateBilling(billing);
        }


        public void AddNewOrder(int Custormerid, string address, string date, string message, int hours)
        {
            orders = cleanDB.GetOrders();
            int i = 0;
            bool trueOrFale = false;
            foreach (Order item in orders)
            {
                i++;
            }
            Order order = new Order();
            order.Id = i + 1;
            order.Message = message;
            order.Timeordered = date;
            order.Custormerid = Custormerid;
            order.Address = address;
            order.Date = date;
            order.Hours = hours;
            order.Price = hours * 150;
            foreach (Company company in companies)
            {
                if(company.Id == order.Id)
                {
                    trueOrFale = true;
                }
            }
            if(trueOrFale == true)
            {
                order.Status = "Company";
            }
            else
            {
                order.Status = "Private";
            }
            cleanDB.AddOrder(order);
        }


        // Får data tilbage fra databasen
        public string ReturnPrivateCustormers()
        {
            string text = "";
            privateCustormers = cleanDB.GetPrivateCustormers();
            foreach (var item in privateCustormers)
            {
                text += $"ID = {item.Id} | Name = {item.Firstname} {item.Lastname} | Address = {item.Address} | Telefon nummer = {item.Tlf}\n";
            }
            return text;
        }

        public string ReturnCompanys()
        {
            string text = "";
            companies = cleanDB.GetCompanys();
            foreach (var item in companies)
            {
                text += $"ID = {item.Id} | Company Name = {item.Companyname} | SE-Nummer = {item.Senumber} | Telefon nummer = {item.Tlf}\n";
            }
            return text;
        }

        public string ReutrnOrders()
        {
            string text = "";
            orders = cleanDB.GetOrders();
            foreach (var item in orders)
            {
                text += $"ID = {item.Id} | CustomerId = {item.Custormerid} | Time Ordered = {item.Timeordered} | Date = {item.Date} | Address = {item.Address} | Message = {item.Message}\n";
            }
            return text;
        }
    }
}
