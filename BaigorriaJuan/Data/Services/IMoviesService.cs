using BaigorriaJuan.Data.Base;
using BaigorriaJuan.Data.ViewModels;
using BaigorriaJuan.Models;

namespace BaigorriaJuan.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
    }
}