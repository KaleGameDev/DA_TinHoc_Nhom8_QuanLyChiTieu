using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Management.Class
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public string TransactionName { get; set; }
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
        public int PlanId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public bool TransactionType { get; set; } // true = thu, false = chi
    }
}
