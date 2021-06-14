using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_201844050_박승민
{
    class Sale
    {
        private int _number;//판매번호
        public int Number
        {
            get
            {
                return _number;
            }
        }
        private int _prodNumber;//상품번호
        public int ProdNumber
        {
            get
            {
                return _prodNumber;
            }
        }
        private DateTime _date;//판매일자
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        private int _count;//판매수량
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

        private int _price; // 총 판매금액
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
