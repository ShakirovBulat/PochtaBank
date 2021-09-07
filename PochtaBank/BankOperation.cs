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
            double KolvoD = Convert.ToDouble(Console.ReadLine());
            double Pstavka = 5.7;
            double summ = Convert.ToDouble(Console.ReadLine());
            acc2.Ballance = 8000;
            acc.Ballance = 5000;
            if (acc.Ballance < summ)
            {
                Console.WriteLine("Operation Failed");
            }
            else 
            {
                Operations.Transaction(acc, acc2, summ);
            }
            if(acc.Ballance<summ)
            {
                Console.WriteLine("Operation Failed");
            }
            else
            {
                Operations.widthdraw(acc, summ);
            }
            Operations.deposit(acc, summ);
            Operations.takeCredit(acc, Pstavka, KolvoD, summ);
        }
    }
}
