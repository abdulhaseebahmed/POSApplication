using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.Model.POSClasses.EntityClasses
{
    class TransactionClass
    {
        public int TransactionID { get; set; }

        public int? AccountID { get; set; }

        public string AccountName { get; set; }

        public int iscredit { get; set; }

        public string transactionDescription { get; set; }

        public DateTime transactionDate { get; set; }

        public DateTime transactionTime { get; set; }

        public double transactionAmount { get; set; }

        public double balance { get; set; }

        public string transactionTimeString { get; set; }

    }
}
