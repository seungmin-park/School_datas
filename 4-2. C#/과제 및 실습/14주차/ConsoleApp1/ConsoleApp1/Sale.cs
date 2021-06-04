using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sale
    {
        public int Number
        {
            get;
            private set;
        }

        public int ProdNumber
        {
            get;
            private set;
        }

        public DateTime Date
        {
            get;
            private set;
        }

        public int Count
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }

        public Sale(int number,int prodNumber, DateTime date, int count, int price)
        {
            Number = number;
            ProdNumber = prodNumber;
            Date = date;
            Count = count;
            Price = price;
        }
    }
}
