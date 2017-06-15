using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Budget.Models
{
    public class SubCategory
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Category_ID { get; set; }
        [ForeignKey("Category_ID")]
        public Category Category { get; set; }
    }
}