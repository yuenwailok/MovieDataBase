using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class MovieDetailViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal ViewerRating { get; set; }
        public decimal ControlledViewerRating { get; set; }
        public string Rating { get; set; }
        public int Quality { get; set; } = 1;        
        public List<string> ActorsName { get; set; }
    }
}