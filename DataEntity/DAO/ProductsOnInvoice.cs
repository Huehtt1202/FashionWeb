using DataEntity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAO
{
    [Table("ProductsOnInvoice")]
    public class ProductsOnInvoice: CommonProperties
    {
        public string POAId { get; set; }
        public double Sale { get; set; }   //Sale of one item
        public int Quantity { get; set; }
        public double TotalPrice { get; set; } 
        public string InvoiceId { get; set; }
        [ForeignKey("POAId")]
        public PropertyOfAttributes PropertyOfAttributes { get; set; }
        [ForeignKey("InvoiceId")]
        public virtual InVoice InVoice { get; set; }

    }
}
