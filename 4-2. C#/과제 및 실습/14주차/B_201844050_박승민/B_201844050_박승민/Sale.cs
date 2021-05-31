using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_201844050_박승민
{
    class Sale
    {
        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
        }
        private int _prodNumber;
        public int ProdNumber
        {
            get
            {
                return _prodNumber;
            }
        }
        private DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public Sale(int number, int prodNumber, DateTime date, int count, int price)
        {
            _number = number;
            _prodNumber = prodNumber;
            _date = date;
            _count = count;
            _price = price;
        }
    }
}
