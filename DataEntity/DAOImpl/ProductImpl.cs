using DataEntity.DAL;
using DataEntity.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAOImpl
{
    public class ProductImpl : IProduct
    {
        FashionWebDBContext fashiondbcontext = new FashionWebDBContext();
        public int Add()
        {
            try
            {

                return 1;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
