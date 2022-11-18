using DataEntity.DAO;
using DataEntity.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.DAOImpl
{
    public interface IGoodsReceivedNoteRepository : IRepository<GoodsReceivedNote>
    {

    }
    public class GoodsReceivedNoteRepository : Repository<GoodsReceivedNote> , IGoodsReceivedNoteRepository
    {
    }
}
