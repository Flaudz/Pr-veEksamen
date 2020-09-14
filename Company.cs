using System;
using System.Collections.Generic;
using System.Text;

namespace PrøveEksamen
{
    public class Company : PrivateCustormer
    {
        // Fields
        private string companyname;
        private string senumber;

        // Properties
        public string Senumber { get => senumber; set => senumber = value; }
        public string Companyname { get => companyname; set => companyname = value; }

        // Constructors
        public Company(int id, string companyname, string senumber, int tlf)
        {
            Id = id;
            Companyname = companyname;
            Tlf = tlf;
        }

        public Company()
        {

        }
    }
}
