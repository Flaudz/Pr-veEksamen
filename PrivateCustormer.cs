using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PrøveEksamen
{
    public class PrivateCustormer
    {
        // Fields
        private int id;
        private string firstname;
        private string lastname;
        private string address;
        private int tlf;

        // Properties
        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Address { get => address; set => address = value; }
        public int Tlf { get => tlf; set => tlf = value; }


        // Constructors
        public PrivateCustormer()
        {

        }

        public PrivateCustormer(int id, string firstname, string lastname, string address, int tlf)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Tlf = tlf;
        }
    }
}
