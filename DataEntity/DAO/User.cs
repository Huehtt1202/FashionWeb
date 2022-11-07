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
    [Table("User")]
    public class User: CommonProperties
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
