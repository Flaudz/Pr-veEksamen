using System;
using System.Collections.Generic;
using System.Text;

namespace PrøveEksamen
{
    class MiddleClass
    {
        CleanITDataBase cleanDB = new CleanITDataBase();

        public void AddNewPrivateCustormer(int id, string firstname, string lastname, string address, int tlf)
        {
            PrivateCustormer custormer = new PrivateCustormer(id, firstname, lastname, address, tlf);
            cleanDB.AddNewPrivateCustormer(custormer);
        }
    }
}
