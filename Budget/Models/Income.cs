using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Budget.Models
{
    public class Income
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Total Amount is required.")]
        public float TotalAmount { get; set; }

        [Required(ErrorMessage = "Income Received Date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime IncomeReceivedDate { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
        public float? BalanceAmount { get; set; }
    }
}