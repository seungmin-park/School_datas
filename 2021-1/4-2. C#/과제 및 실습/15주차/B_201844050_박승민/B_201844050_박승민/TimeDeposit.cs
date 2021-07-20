using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_201844050_박승민
{
    class TimeDeposit : Account, IExpirable
    {
        DateTime ExpireDate
        {
            get;
            set;
        }

        public TimeDeposit(string number, string customer, long balance, DateTime expiredate)
            :base(number, customer, balance)
        {
            this.ExpireDate = expiredate;
        }
        
        public bool CheckExpire()
        {
            return false;
        }
    }
}
