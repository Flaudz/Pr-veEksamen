using System;
using System.Collections.Generic;
using System.Text;

namespace PrøveEksamen
{
    public class Billing
    {
        // Fields
        private int id;
        private int custormerid;
        private int price;
        private int hours;

        // Properties
        public int Id { get => id; set => id = value; }
        public int Custormerid { get => custormerid; set => custormerid = value; }
        public int Price { get => price; set => price = value; }
        public int Hours { get => hours; set => hours = value; }

        // Constructor
        public Billing(int id, int custormerid, int hours)
        {
            Id = id;
            Custormerid = custormerid;
            Hours = hours;
        }

        public Billing(int id, int custormerid, int price, int hours)
        {
            Id = id;
            Custormerid = custormerid;
            Price = price;
            Hours = hours;
        }

        public Billing()
        {
        }
    }
}
