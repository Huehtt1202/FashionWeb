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
    [Table("Product")]
    public class Product : CommonProperties
    {
        public Product()
        {
            this.Categorys = new HashSet<Category>();
            this.Attributes = new HashSet<Attributes>();
        }

        [Required(ErrorMessage = "Field is not null")]
        [StringLength(100)]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Image { get; set; }
        public string Substance { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public double Cost { get; set; }
        //public string CategeryId { get; set; }
        [ForeignKey("CategeryId")]
        public virtual ICollection<Category> Categorys { get; set; }
        public virtual ICollection<Attributes> Attributes { get; set; }
    }
}
