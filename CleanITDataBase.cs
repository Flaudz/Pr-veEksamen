﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace PrøveEksamen
{
    public class CleanITDataBase
    {
        private string connectionString = "Data Source=CV-BB-5992;Initial Catalog=CleanIT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private DataSet Execute(string query)
        {
            DataSet resultSet = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
            {
                adapter.Fill(resultSet);
            }
            return resultSet;
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Private kunde


        // Tilføj En ny private kunde
        public void AddNewPrivateCustormer(PrivateCustormer privateCustormer)
        {
            string addNewPrivateCustormer =
                $"INSERT INTO PrivateCustormers VALUES('{privateCustormer.Id}', '{privateCustormer.Firstname}', '{privateCustormer.Lastname}', '{privateCustormer.Address}', '{privateCustormer.Tlf}')";
            try
            {
            Execute(addNewPrivateCustormer);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Får information fra databasen og laver en kunde for hver af kunderne i databasen og returner dem
        public List<PrivateCustormer> GetPrivateCustormers()
        {
            List<PrivateCustormer> pCustormerList = new List<PrivateCustormer>();
            string allPrivateCustormersQuery = "SELECT * FROM PrivateCustormers";

            // Exikver query og gemmer i en variabel
            DataSet resultSet = Execute(allPrivateCustormersQuery);

            // Får første table af data sættet og gemmer i en variabel
            DataTable privateCustormerTable = resultSet.Tables[0];


            foreach (DataRow pCustormerRow in privateCustormerTable.Rows)
            {
                int id = (int)pCustormerRow["id"];
                string firstName = (string)pCustormerRow["FirstName"];
                string lastName = (string)pCustormerRow["LastName"];
                string address = (string)pCustormerRow["Address"];
                int tlf = (int)pCustormerRow["Tlf"];
                PrivateCustormer pCustormer = new PrivateCustormer();
                pCustormer.Id = id;
                pCustormer.Firstname = firstName;
                pCustormer.Lastname = lastName;
                pCustormer.Address = address;
                pCustormer.Tlf = tlf;
                pCustormerList.Add(pCustormer);
            }
            return pCustormerList;
        }


        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Firmaer

        // Tilføjer et nyt firma
        public void AddNewCompany(Company comapny)
        {
            string addNewCompany =
                $"INSERT INTO Companys VALUES('{comapny.Id}', '{comapny.Companyname}', '{comapny.Senumber}', '{comapny.Tlf}')";
            try
            {
                Execute(addNewCompany);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Får information omkring firmaer fra databasen
        public List<Company> GetCompanys()
        {
            List<Company> CompanyList = new List<Company>();
            string allCompanysQuery = "SELECT * FROM Companys";

            // Exikver query og gemmer i en variabel
            DataSet resultSet = Execute(allCompanysQuery);

            // Får første table af data sættet og gemmer i en variabel
            DataTable companyTable = resultSet.Tables[0];


            foreach (DataRow companyRow in companyTable.Rows)
            {
                int id = (int)companyRow["id"];
                string companyName = (string)companyRow["CompanyName"];
                string SENumber = (string)companyRow["SeNumber"];
                int tlf = (int)companyRow["Tlf"];
                Company company = new Company();
                company.Id = id;
                company.Companyname = companyName;
                company.Senumber = SENumber;
                company.Tlf = tlf;
                CompanyList.Add(company);
            }
            return CompanyList;
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Regninger


        // Tilføj En ny pris
        public void AddNewPrivateBilling(Billing billing)
        {
            string addNewBillingForPrivate =
                $"INSERT INTO Billing VALUES('{billing.Id}', '{billing.Custormerid}', '{billing.Price}', '{billing.Hours}')";
            
            try
            {
                Execute(addNewBillingForPrivate);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Får informationer omkring regninger fra databasen
        public List<Billing> GetBillings()
        {
            List<Billing> BillingList = new List<Billing>();
            string allBillingsQuery = "SELECT * FROM Billing";

            DataSet resultSet = Execute(allBillingsQuery);


            DataTable billingTable = resultSet.Tables[0];


            foreach (DataRow billingRow in billingTable.Rows)
            {
                int id = (int)billingRow["id"];
                int custormerid = (int)billingRow["CustormerId"];
                int price = (int)billingRow["Price"];
                int hours = (int)billingRow["Hours"];

                Billing billing = new Billing();
                billing.Id = id;
                billing.Custormerid = custormerid;
                billing.Price = price;
                billing.Hours = hours;
                BillingList.Add(billing);
            }
            return BillingList;
        }
    }
}
