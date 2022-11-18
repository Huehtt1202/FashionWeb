using DataEntity.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAOImpl
{
    public interface IAttributesRepository : IRepository<Attribute>
    {

    }
    public class AttributesRepository : Repository<Attribute> , IAttributesRepository
    {

    }
}
