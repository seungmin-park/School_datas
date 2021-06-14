using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_201844050_박승민
{
    class Product
    {
        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        private int _stockCount;
        public int StockCount
        {
            get
            {
                return _stockCount;
            }
        }

        private int _unitPrice;
        public int UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }

        private double _discountRate;
        public double DiscountRate
        {
            get
            {
                return _discountRate;
            }
            set
            {
                _discountRate = value;
            }
        }

        public Product(int number,string name, int unitprice, int stockcount, double discountrate)
        {
            _number = number;
            _name = name;
            _stockCount = stockcount;
            _unitPrice = unitprice;
            _discountRate = discountrate;

        }

        public void StockCountUp(int stockcount)
        {
            this._stockCount += stockcount;
        }

        public int Sale(int saleCount)
        {
            double account = 0;
            if(_stockCount >= saleCount)
            {
                _stockCount -= saleCount;
                if(saleCount >= 30)
                {
                account = (saleCount * _unitPrice) * (1 - _discountRate);
                }
                else
                {
                    account = (saleCount * _unitPrice);
                }
            }
            else
            {
                //에러반환
            }
            return (int)account;
        }
    }
}
