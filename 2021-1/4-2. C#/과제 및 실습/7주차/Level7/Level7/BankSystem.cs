using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level7
{
    class BankSystem
    {
        static List<Account> accounts = null;//인스턴스 변수 클래스안 에서 서언 static 안붙음
        static void Main(string[] args)
        {

            //Account acc1 = new Account();
            Account acc2 = new Account("111-111-111", "김인하", 1000);
            Account acc3 = new Account("211-111-111", "이인하");
            Console.Read();

            acc2.Deposit(10000);//seter 역할
            acc2.WithDraw(2000);
            acc2.Owner = "박인하";
            Console.WriteLine(acc2.Owner);
            Console.WriteLine(acc2.Info());

            //accounts = new list<account>();//클래스메소드는 인스턴스 변수에 접근할수없음

            //account acc1 = new account();
            //account acc2 = new account();

            //acc1._number = "111-111";
            //acc1._owner = "김인하";
            //acc1._balance = 1000;

            //accounts.add(acc1);
            //accounts.add(acc2);

            //accounts[0].withdraw(10000);//acc1의 잔액이 1000이라 10000을 빼는것이 불가능해 false
            //acc1.deposit(10);
            //acc2.deposit(200);
            //accounts[1].withdraw(1);

            //console.writeline(acc1._balance);
            //console.writeline(acc2._balance);
        }
    }
}
