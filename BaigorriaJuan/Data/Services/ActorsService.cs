using BaigorriaJuan.Data.Base;
using BaigorriaJuan.Models;
using Microsoft.EntityFrameworkCore;

namespace BaigorriaJuan.Data.Services
{
    public class ActorsService : EntityBaseRepository <Actor>,IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
        

    }
}