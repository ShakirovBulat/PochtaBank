using System;
using System.Collections.Generic;
using System.Text;

namespace PochtaBank
{
    class BankAccount
    {
        private double _Ballance;
        private double _Zadoljennost;

        public double Ballance{get ; set;}

        public double Zadoljennost { get; set; }

        public static double Pstavka = 5.7;
    }
}
