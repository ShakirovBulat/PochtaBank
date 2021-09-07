﻿using System;

namespace PochtaBank
{
    class Operations
    {
        public static void ShowBalance(BankAccount account)
        {
            System.Console.WriteLine(account.Ballance);
        }
        public static void Transaction(BankAccount accountSeller, BankAccount accountGetter, double summ )
        {
            accountSeller.Ballance -= summ;
            accountGetter.Ballance += summ;
            System.Console.WriteLine("Transaction Completed");
            Console.WriteLine($"ballance sell - {accountSeller.Ballance}, ballance get - {accountGetter.Ballance}");
        }
        public static int widthdraw(BankAccount account, double summ)
        {
            account.Ballance -= summ;
            System.Console.WriteLine("widthdraw Completed");
            System.Console.WriteLine($"ballance account - {account.Ballance}");
            return (int)summ;
        }
        public static int deposit(BankAccount account1, double summ)
        {
            account1.Ballance += summ;
            System.Console.WriteLine("Deposit Completed");
            System.Console.WriteLine($"ballance account1 - {account1.Ballance}");
            return (int)summ;
        }
        public static int takeCredit(BankAccount account2, double summ, double kolvoD, double Pstavka)
        {
            account2.Ballance += summ;
            account2.Zadoljennost += (int)(summ * (Pstavka + (Pstavka / (1 + Pstavka) * kolvoD - 1)));
            System.Console.WriteLine("Credit Completed");
            System.Console.WriteLine($"ballance account2 - {account2.Ballance}");
            System.Console.WriteLine($"Zadoljennost account2 - {account2.Zadoljennost}");
            return (int)summ;
        }
    }
}
