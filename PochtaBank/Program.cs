using System;

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
            System.Console.WriteLine(account.Ballance);
            return (int)summ;
        }
        public static int deposit(BankAccount account1, double summ)
        {
            account1.Ballance += summ;
            System.Console.WriteLine("Deposit Completed");
            System.Console.WriteLine(account1.Ballance);
            return (int)summ;
        }
        public static int takeCredit()
        {
            return 0;
        }
    }
}
