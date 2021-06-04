using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public int Number
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public int StockCount
        {
            get;
            private set;
        }

        public int UnitPrice
        {
            get;
            set;
        }

        public double DiscountRate
        {
            get;
            set;
        }

        public Product(int number, string name, int stockcount, int unitprice, double discountRate)
        {
            Number = number;
            Name = name;
            StockCount = stockcount;
            UnitPrice = unitprice;
            DiscountRate = discountRate;
        }

        public void AddStockCount(int addcount)
        {
            this.StockCount += addcount;
        }

        public int Sale(int count)
        {
            if(count > StockCount)
            {
                throw new Exception("재고수량 없음");
            }
            else
            {
                StockCount -= count;
                return (int)(count * UnitPrice * (count >= 30 ? (1.0 - DiscountRate) : 1));
            }
        }
    }
}
