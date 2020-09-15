using System;
using System.Collections.Generic;
using System.Text;

namespace PrøveEksamen
{
    public class AllCustormers
    {
        // Fields
        private int id;
        private string status;

        public int Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }

        public AllCustormers(int id, string status)
        {
            Id = id;
            Status = status;
        }

        public AllCustormers()
        {

        }
    }
}
