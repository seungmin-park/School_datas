using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_201844050_박승민
{
    class InstallmentSaving : Account,IExpirable
    {
        DateTime ExpireDate
        {
            get;
            set;
        }

        public bool CheckExpire()
        {
            return false;
        }

        public override bool Expire(out long money)
        {
            money = 0;
            return false;
        }

        public InstallmentSaving(string number, string customer, long balance, DateTime expiredate)
            :base(number, customer, balance)
        {
            this.ExpireDate = expiredate;
        }

        public override bool Withdraw(long money)
        {
            return false;
        }
    }
}
