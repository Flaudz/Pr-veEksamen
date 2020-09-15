using System;
using System.Collections.Generic;
using System.Text;

namespace PrøveEksamen
{
    public class Order
    {
        private int id;
        private int custormerid;
        private string status;
        private int price;
        private int hours;
        private string message;
        private string date;
        private string timeordered;
        private string address;

        public int Id { get => id; set => id = value; }
        public int Custormerid { get => custormerid; set => custormerid = value; }
        public string Status { get => status; set => status = value; }
        public int Price { get => price; set => price = value; }
        public int Hours { get => hours; set => hours = value; }
        public string Message { get => message; set => message = value; }
        public string Date { get => date; set => date = value; }
        public string Timeordered { get => timeordered; set => timeordered = value; }
        public string Address { get => address; set => address = value; }

        public Order(int id, int custormerid, string status, int price, int hours, string message, string date, string timeordered, string address)
        {
            Id = id;
            Custormerid = custormerid;
            Status = status;
            Price = price;
            Hours = hours;
            Message = message;
            Date = date;
            Timeordered = timeordered;
            Address = address;
        }
        public Order()
        {

        }
    }
}
