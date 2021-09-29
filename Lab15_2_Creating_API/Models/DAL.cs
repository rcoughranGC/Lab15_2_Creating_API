using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace Lab15_2_Creating_API.Models
{
    public class DAL
    {
        public static MySqlConnection DB;
        public static List<Movie> GetAllMovies()                 
        {
            return DB.GetAll<Movie>().ToList();
        }
               
        public static List<Movie> GetMoviesByGenre(string genre)
        {
            var keyValues = new { genre = genre };
            string sql = "select * from movies where genre = @genre";
            return DB.Query<Movie>(sql, keyValues).ToList();
        }

        public static Movie GetMovie(int id)                   
        {
            return DB.Get<Movie>(id);
        }
        public static List<Movie> SearchMovieTitles(string title)
        {
            title = $"%{title}%";
            var keyValues = new { title = title };
            string sql = "select * from movies where title like @title";
            return DB.Query<Movie>(sql, keyValues).ToList();
        }
        public static bool DeleteMovie(int id)                 
        {
            Movie movieToDelete = DB.Get<Movie>(id);
            DB.Delete<Movie>(movieToDelete);
            return true;
        }

        public static Movie UpdateMovie(Movie mov)              
        {
            DB.Update<Movie>(mov);
            return mov;
        }
        public static Movie AddMovie(Movie mov)
        {
            DB.Insert<Movie>(mov);
            return mov;
        }
    }
}
