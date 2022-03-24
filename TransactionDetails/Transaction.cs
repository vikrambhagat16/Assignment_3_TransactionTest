using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace TransactionDetails
{
    public class Transaction
    {
        public decimal Amount { get; }
        public string AmountForHuman
        {
            get { return ((int)Amount).ToWords(); }
        }
        public DateTime Date { get; }
        public string Notes { get; }
        public Transaction(decimal amount, DateTime date, string notes)
        {
            Amount = amount;
            Date = date;
            Notes = notes;
        }

        public void printAccountDetails()
        {
            Console.WriteLine("Amount : "+Amount + " Date : "+ Convert.ToDateTime(Date).ToString("dd/MM/yyyy"));
            Console.WriteLine("Human Readable Amount : " + AmountForHuman);
        }
    }

}
