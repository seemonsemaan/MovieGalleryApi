using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieGalleryApi.Classes;
using MovieGalleryApi.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DbController : ControllerBase
    {
        private readonly IDbRepository dbRepository;

        public DbController(IDbRepository dbRepository)
        {
            this.dbRepository = dbRepository;
        }

        [HttpGet("GetTopMovies")]
        public async Task<IActionResult> GetTopMovies()
        {
            var result = await dbRepository.GetTopMovies();
            result.Results = result.Results.ToList().GetRange(0, 6);
            return Ok(result);
        }

        [HttpGet("GetTopTv")]
        public async Task<IActionResult> GetTopTv()
        {
            try
            {
                var result = await dbRepository.GetTopTv();
                result.Results = result.Results.ToList().GetRange(0, 6);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetGenres/{type}")]
        public async Task<IActionResult> GetGenres(string type)
        {
            var result = await dbRepository.GetGenre(type);
            return Ok(result.Genres);
        }

        [HttpGet("GetMovieDetails/{movie_id}")]
        public async Task<IActionResult> GetMovieDetails(string movie_id)
        {
            var result = await dbRepository.GetMovieDetails(movie_id);
            return Ok(result);
        }

        [HttpGet("GetTvDetails/{tv_id}")]
        public async Task<IActionResult> GetTvDetails(string tv_id)
        {
            var result = await dbRepository.GetTvDetails(tv_id);
            return Ok(result);
        }

        [HttpGet("MovieDiscover/{query}")]
        public async Task<IActionResult> MovieDiscover(string query)
        {
            try
            {
                var result = await dbRepository.MovieDiscover(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("TvDiscover/{query}")]
        public async Task<IActionResult> TvDiscover(string query)
        {
            try
            {
                var result = await dbRepository.TvDiscover(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
