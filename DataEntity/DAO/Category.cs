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
    [Table("Category")]
    public class Category: CommonProperties
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        [Required(ErrorMessage = "Field is not null")]
        [StringLength(20)]

        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
