using DataEntity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAO
{
    [Table("supplier")]
    public class Supplier: CommonProperties
    {
        public string SupplierName { get; set; }
        public int TaxCode { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Commune { get; set; }
        public string DetailAddress { get; set; }
        public int PhoneNumber { get; set; }
    }
}
