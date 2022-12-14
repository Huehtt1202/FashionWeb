using DataEntity.DAO;
using DataEntity.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAOImpl
{
    public interface IUserRepository : IRepository<User>
    {

    }
    public class UserRepository: Repository<User>, IUserRepository
    {
    }
}
