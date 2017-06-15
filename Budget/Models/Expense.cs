using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Budget.Models
{
    public class Expense
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Amount is required.")]
        public float Amount { get; set; }
        [Required(ErrorMessage = "DateIncurred is required.")]

        [DataType(DataType.DateTime)]
        public DateTime DateIncurred { get; set; }

        [ForeignKey("Category_ID")]
        public virtual Category Category {get; set;}
        public int Category_ID { get; set; }

        [ForeignKey("SubCategory_ID")]
        public virtual SubCategory SubCategory { get; set; }
        public int SubCategory_ID { get; set; }

        [ForeignKey("Income_ID")]
        public virtual Income Income { get; set; }
        public int Income_ID { get; set; }
    }
}