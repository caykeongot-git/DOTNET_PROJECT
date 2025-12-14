using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab04_04.DAL.Entities
{
    public class Product
    {
        [Key]
        [StringLength(20)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
