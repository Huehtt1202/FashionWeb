using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAO
{
    [Table("Stock")]
    public class Stock
    {
        [Key]
        public string LogId { get; set; }
        public string AttributesId { get; set; }
        public string NoteOrInvoiceId { get; set; }
        public int QuantityOfVeriation { get; set; }
        public int QuantityCurrent { get; set; }
        [ForeignKey("AttributesId")]
        public virtual Attributes Attributes { get; set; }
    }
}
