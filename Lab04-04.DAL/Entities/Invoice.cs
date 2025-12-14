using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab04_04.DAL.Entities
{
    public class Invoice
    {
        [Key]
        [StringLength(20)]
        public string InvoiceNo { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
