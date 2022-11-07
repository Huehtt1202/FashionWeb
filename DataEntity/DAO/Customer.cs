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
    [Table("Customer")]
    public class Customer: CommonProperties
    {
        [Required(ErrorMessage = "Field is not null")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string City { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string District { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string Commune { get; set; }
        [Required(ErrorMessage = "Field is not null")]
        public string DetailAddress { get; set; }
    }
}
