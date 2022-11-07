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
    [Table("InVoice")]
    public class InVoice: CommonProperties
    {
        public double TotalBeforeVAT { get; set; }
        public double TotalAfterVAT { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public double VAT { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public double DeliveryFee{ get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string Status { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
