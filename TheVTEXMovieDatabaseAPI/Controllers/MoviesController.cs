using Business.Contracts;
using Business.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace TheVTEXMovieDatabaseAPI.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieManager _movieManager { get; set; }

        public MoviesController(IMovieManager movieManager)
        {
            _movieManager = movieManager;
        }

        [HttpGet]
        [Route("allmovies")]
        [ProducesResponseType(typeof(IEnumerable<MoviesDTO>), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<MoviesDTO>> GetAllMovies(
            [FromQuery] int pageSize = 10,
            [FromQuery] string genero = "")
        {
            return await _movieManager.GetAllMovies(pageSize, genero);
        }
    }
}
