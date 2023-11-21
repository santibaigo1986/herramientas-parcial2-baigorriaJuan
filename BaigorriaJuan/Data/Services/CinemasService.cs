using BaigorriaJuan.Data.Base;
using BaigorriaJuan.Models;

namespace BaigorriaJuan.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
