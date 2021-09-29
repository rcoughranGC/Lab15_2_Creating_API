using Lab15_2_Creating_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace Lab15_2_Creating_API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        [HttpGet("readall")]
        public List<Movie> GetAllMovies()
        {
            return DAL.GetAllMovies();
        }

        [HttpGet("readbygenre")]
        public List<Movie> GetMoviesByGenre(string genre)
        {
            return DAL.GetMoviesByGenre(genre);
        }
        [HttpGet("readone")]
        public Movie GetMovie(int id)
        {
            return DAL.GetMovie(id);
        }
        [HttpGet("searchtitles")]
        public List<Movie> SearchTitles(string title)
        {
            return DAL.SearchMovieTitles(title);
        }

        [HttpDelete("deletemovie")]
        public bool DeleteMovie(int id)
        {
            return DAL.DeleteMovie(id);
        }

        [HttpPut("updatemovie")]
        public Movie UpdateMovie(Movie mov)
        {
            return DAL.UpdateMovie(mov);
        }

        [HttpPost("addmovie")]
        public Movie AddMovie(Movie mov)
        {
            return DAL.AddMovie(mov);
        }

    }
}
