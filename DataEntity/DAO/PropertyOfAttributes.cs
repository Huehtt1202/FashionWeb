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
    [Table("PropertyOfAttributes")]
    public class PropertyOfAttributes: CommonProperties
    {
        public string AttributesId { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string POAName { get; set; }
        [ForeignKey("AttributesId")]
        public virtual Attributes Attributes { get; set; }
    }
}
