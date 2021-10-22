using MovieGalleryApi.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.IRepositories
{
    public interface IDbRepository
    {
        Task<MovieResult> GetTopMovies();
        Task<TvShowResult> GetTopTv();
        Task<GenreResult> GetGenre(string type);
        Task<MovieDetail> GetMovieDetails(string movie_id);
        Task<TvShowDetail> GetTvDetails(string tv_id);
        Task<MovieResult> MovieDiscover(string query);
        Task<TvShowResult> TvDiscover(string query);
    }
}
