using BaigorriaJuan.Data;
using BaigorriaJuan.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaigorriaJuan.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }
        //GET: Movies/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        //GET: Movies/Create
        public IActionResult Create()
        {
            ViewData["Welcome"] = "Bienvenidos a Nuestra Tienda";
            ViewBag.Description = "Esta es la Descripcion de la tienda";

            return View();
        }
    }
}
    