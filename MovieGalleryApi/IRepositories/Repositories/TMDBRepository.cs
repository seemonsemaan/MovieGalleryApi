using MovieGalleryApi.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieGalleryApi.IRepositories.Repositories
{
    public class TMDBRepository : IDbRepository
    {
        private readonly ApiStrings apiStrings;

        public TMDBRepository(ApiStrings apiStrings)
        {
            this.apiStrings = apiStrings;
        }

        public async Task<GenreResult> GetGenre(string type)
        {
            using (HttpClient http = new HttpClient())
            {
                var result = await http.GetAsync(apiStrings.ApiUrl + "/genre/" + type + "/list?api_key=" + apiStrings.ApiKey);
                var jsonString = await result.Content.ReadAsStringAsync();

                GenreResult genreResult = JsonSerializer.Deserialize<GenreResult>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return genreResult;
            }
        }

        public async Task<MovieDetail> GetMovieDetails(string movie_id)
        {
            using (HttpClient http = new HttpClient())
            {
                var result = await http.GetAsync(apiStrings.ApiUrl + "/movie/"+ movie_id +"?api_key=" + apiStrings.ApiKey);
                if (((int)result.StatusCode) != 200)
                    throw new Exception(((int)result.StatusCode).ToString());

                var jsonString = await result.Content.ReadAsStringAsync();

                MovieDetail movieDetail = JsonSerializer.Deserialize<MovieDetail>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return movieDetail;
            }
        }

        public async Task<MovieResult> GetTopMovies()
        {
            using (HttpClient http = new HttpClient())
            {
                var result = await http.GetAsync(apiStrings.ApiUrl + "/movie/top_rated?api_key=" + apiStrings.ApiKey);
                var jsonString = await result.Content.ReadAsStringAsync();

                MovieResult movieResult = JsonSerializer.Deserialize<MovieResult>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true  });
                return movieResult;
            }
        }

        public async Task<TvShowResult> GetTopTv()
        {
            using (HttpClient http = new HttpClient())
            {
                var result = await http.GetAsync(apiStrings.ApiUrl + "/tv/top_rated?api_key=" + apiStrings.ApiKey);
                if (((int)result.StatusCode) != 200)
                    throw new Exception(((int)result.StatusCode).ToString());

                var jsonString = await result.Content.ReadAsStringAsync();

                TvShowResult tvShowResult = JsonSerializer.Deserialize<TvShowResult>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true  });
                return tvShowResult;
            }
        }

        public async Task<TvShowDetail> GetTvDetails(string tv_id)
        {
            using (HttpClient http = new HttpClient())
            {
                var result = await http.GetAsync(apiStrings.ApiUrl + "/tv/" + tv_id + "?api_key=" + apiStrings.ApiKey);
                if (((int)result.StatusCode) != 200)
                    throw new Exception(((int)result.StatusCode).ToString());

                var jsonString = await result.Content.ReadAsStringAsync();

                TvShowDetail tvDetail = JsonSerializer.Deserialize<TvShowDetail>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return tvDetail;
            }
        }

        public async Task<MovieResult> MovieDiscover(string query)
        {
            using (HttpClient http = new HttpClient())
            {
                var result = await http.GetAsync(apiStrings.ApiUrl + "/discover/movie?" + query);
                if (((int)result.StatusCode) != 200)
                    throw new Exception(((int)result.StatusCode).ToString());

                var jsonString = await result.Content.ReadAsStringAsync();

                MovieResult movieResult = JsonSerializer.Deserialize<MovieResult>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return movieResult;
            }
        }

        public async Task<TvShowResult> TvDiscover(string query)
        {
            using (HttpClient http = new HttpClient())
            {
                var result = await http.GetAsync(apiStrings.ApiUrl + "/discover/tv?" + query);
                if (((int)result.StatusCode) != 200)
                    throw new Exception(((int)result.StatusCode).ToString());

                var jsonString = await result.Content.ReadAsStringAsync();

                TvShowResult tvShowResult = JsonSerializer.Deserialize<TvShowResult>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return tvShowResult;
            }
        }
    }
}
