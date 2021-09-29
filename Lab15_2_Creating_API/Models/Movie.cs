using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Lab15_2_Creating_API.Models
{
    [Table("movies")]
    public class Movie
    {
        
        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
    }
}
