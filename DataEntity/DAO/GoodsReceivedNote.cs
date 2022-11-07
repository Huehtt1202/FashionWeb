using DataEntity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAO
{
    [Table("GoodsReceivedNote")]
    public class GoodsReceivedNote: CommonProperties
    {
        public string SupplierId { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public double TotalBeforeVAT { get; set; }
        public double TotalAfterVAT { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public double VAT { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public bool StatusOfPay { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string Payment { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }
    }
}
