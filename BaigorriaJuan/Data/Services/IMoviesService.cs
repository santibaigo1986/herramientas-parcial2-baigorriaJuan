using BaigorriaJuan.Data.Base;
using BaigorriaJuan.Models;

namespace BaigorriaJuan.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<NewMovieVM>
    {
        Task<NewMovieVM> GetMovieByIdAsync(int id);
    }
}