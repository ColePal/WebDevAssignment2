using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmFriends.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public float? Budget { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        [DataType(DataType.Date)]
        public DateTime RealeaseDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? UpdatedDate { get; set; }
        public ICollection<string> Directors { get; set; }
        public ICollection<string> Actors { get; set;}
        public ICollection<string> Producers { get; set; }

    }
}