using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        // Tilføj En ny private kunde
        public void AddNewPrivateCustormer(PrivateCustormer privateCustormer)
        {
            string addNewPrivateCustormer =
                $"INSERT INTO PrivateCustormers (id, FirstName, LastName, Address, Tlf)({privateCustormer.Id}, {privateCustormer.Firstname}, {privateCustormer.Lastname}, {privateCustormer.Address}, {privateCustormer.Tlf})";
            Execute(addNewPrivateCustormer);
        }

        // Får information fra databasen og laver en kunde for hver af kunderne i databasen og returner dem
        public PrivateCustormer GetPrivateCustormers()
        {
            PrivateCustormer pCustormer = new PrivateCustormer();
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

                pCustormer.Id = id;
                pCustormer.Firstname = firstName;
                pCustormer.Lastname = lastName;
                pCustormer.Address = address;
                pCustormer.Tlf = tlf;
            }
            return pCustormer;
        }
    }
}
