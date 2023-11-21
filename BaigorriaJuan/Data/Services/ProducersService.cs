using BaigorriaJuan.Data.Base;
using BaigorriaJuan.Models;

namespace BaigorriaJuan.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
