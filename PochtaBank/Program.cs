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
        }
    }
}
