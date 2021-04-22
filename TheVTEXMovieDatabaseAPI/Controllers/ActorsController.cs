using Business.Contracts;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TheVTEXMovieDatabaseAPI.Controllers
{
    public class ActorsController : ControllerBase
    {
        private IActorsManager _actorsManager { get; set; }

        public ActorsController(IActorsManager actorsManager)
        {
            _actorsManager = actorsManager;
        }

        [HttpGet]
        [Route("allactors")]
        [ProducesResponseType(typeof(IEnumerable<Actors>), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<Actors>> GetAllMovies()
        {
            return await _actorsManager.GetAllActors();
        }

        [HttpGet]
        [Route("allactorsxmovie")]
        [ProducesResponseType(typeof(IEnumerable<string>), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<string>> GetAllMovies([FromQuery] string movieName)
        {
            return await _actorsManager.GetActorsByMovie(movieName);
        }
    }
}
