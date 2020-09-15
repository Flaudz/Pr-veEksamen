using System;
using System.Collections.Generic;
using System.Text;

namespace PrøveEksamen
{
    class MiddleClass
    {
        CleanITDataBase cleanDB = new CleanITDataBase();
        List<PrivateCustormer> privateCustormers = new List<PrivateCustormer>();
        List<Company> companies = new List<Company>();
        List<Billing> billings = new List<Billing>();
        public List<PrivateCustormer> PrivateCustormers { get => privateCustormers; set => privateCustormers = value; }
        public List<Company> Companies { get => companies; set => companies = value; }
        public List<Billing> Billings { get => billings; set => billings = value; }

        public void AddNewCompany(string companyname, string senumber, int tlf)
        {
            companies = cleanDB.GetCompanys();
            int i = 0;
            foreach (var item in companies)
            {
                i++;
            }
            Company company = new Company(i+1, companyname, senumber, tlf);
            cleanDB.AddNewCompany(company);
        }

        public void AddNewPrivateCustormer(string firstname, string lastname, string address, int tlf)
        {
            privateCustormers = cleanDB.GetPrivateCustormers();
            int i = 0;
            foreach (var item in privateCustormers)
            {
                i++;
            }
            PrivateCustormer custormer = new PrivateCustormer(i+1, firstname, lastname, address, tlf);
            cleanDB.AddNewPrivateCustormer(custormer);
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
            billing.Id = i++;
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
    }
}
