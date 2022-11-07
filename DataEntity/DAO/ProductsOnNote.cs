using DataEntity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAO
{
    [Table("ProductsOnNote")]
    public class ProductsOnNote: CommonProperties
    {
        public string POAId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice1 { get; set; }
        public bool DiscountType { get; set; } //true=percent, false= unit
        public double DiscountValue { get; set; }
        public double TotalPrice2 { get; set; }
        public string GoodsReceivedNoteId { get; set; }
        [ForeignKey("POAId")]
        public PropertyOfAttributes PropertyOfAttributes { get; set; }
        [ForeignKey("GoodsReceivedNoteId")]
        public virtual GoodsReceivedNote GoodsReceivedNot { get; set; }
    }
}
