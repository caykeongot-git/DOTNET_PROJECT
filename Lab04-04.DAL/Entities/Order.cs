using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_04.DAL.Entities
{
    public class Order
    {
        public string InvoiceNo { get; set; }
        public int No { get; set; }

        public string ProductID { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("InvoiceNo")]
        public virtual Invoice Invoice { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
