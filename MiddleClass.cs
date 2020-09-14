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
        public List<PrivateCustormer> PrivateCustormers { get => privateCustormers; set => privateCustormers = value; }
        public List<Company> Companies { get => companies; set => companies = value; }


        public void AddNewCompany(int id, string companyname, string senumber, int tlf)
        {
            Company company = new Company(id, companyname, senumber, tlf);
            cleanDB.AddNewCompany(company);
        }

        public void AddNewPrivateCustormer(int id, string firstname, string lastname, string address, int tlf)
        {
            PrivateCustormer custormer = new PrivateCustormer(id, firstname, lastname, address, tlf);
            cleanDB.AddNewPrivateCustormer(custormer);
        }

        public void AddNewBilling(int id, int Custormerid, int hours)
        {
            Billing billing = new Billing();
            billing.Id = id;
            billing.Custormerid = Custormerid;
            billing.Hours = hours;
            billing.Price = hours * 150;
            cleanDB.AddNewPrivateBilling(billing);
        }

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
