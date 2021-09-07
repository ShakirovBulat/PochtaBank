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
            Console.Write("Сколько денег - ");
            double summ = Convert.ToDouble(Console.ReadLine());
            acc.Ballance = 5000;
            acc2.Ballance = 8000;
            {
                Console.WriteLine("1)Transaction");
                Console.WriteLine("2)widthdraw");
                Console.WriteLine("3)deposit");
                Console.WriteLine("4)takeCredit");
                Console.Write("Выберите пункт меню");
                String str = Console.ReadLine();
                
                switch (str)
                {
                    case "1":

                        if (acc.Ballance < summ)
                        {
                            Console.WriteLine("Operation Failed");
                        }
                        else
                        {
                            Operations.Transaction(acc, acc2, summ);
                        }
                        break;
                    case "2":
                        if (acc.Ballance < summ)
                        {
                            Console.WriteLine("Operation Failed");
                        }
                        else
                        {
                            Operations.widthdraw(acc, summ);
                        }
                        break;
                    case "3":
                        Operations.deposit(acc, summ);
                        break;
                    case "4":
                        Console.Write("На сколько дней взять кредит - ");
                        double KolvoD = Convert.ToDouble(Console.ReadLine());
                        Operations.takeCredit(acc, BankAccount.Pstavka, KolvoD, summ);
                        break;
                    case "0":
                        return;
                } while (true) ;
            }


        }
    }
}
