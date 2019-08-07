using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace InterfaceApp
{
   public interface ITransactions
    {
        //interface members
        void showTransactions();
        double getAmount();
    }
    public class Transaction : ITransactions { 
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransactions()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }


    class Tester
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "08/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "09/10/2012", 415900.00);

            t1.showTransactions();
            t2.showTransactions();
            Console.ReadKey();
        }
    }
}
