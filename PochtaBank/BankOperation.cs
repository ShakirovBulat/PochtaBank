using System;
using System.Collections.Generic;
using System.Text;

namespace PochtaBank
{
    class BankOperation
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            BankAccount acc2 = new BankAccount();
            double summd = 1000;
            acc2.Ballance = 8000;
            acc.Ballance = 5000;
            if (acc.Ballance < summd)
            {
                Console.WriteLine("Operation Failed");
            }
            else 
            {
                Operations.Transaction(acc, acc2, summd);
            }
            if(acc.Ballance<summd)
            {
                Console.WriteLine("Operation Failed");
            }
            else
            {
                Operations.widthdraw(acc, summd);
            }
            Operations.deposit(acc, summd);
            Operations.takeCredit(acc, summd);
        }
    }
}
