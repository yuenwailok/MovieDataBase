using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class ActorMovie
    {
        public int ActorMovieID { get; set; }
        public int MovieID { get; set; }
        
        public int ActorID { get; set; }
        
        public virtual Actor Actor { get; set; }

        public virtual Movie Movie { get; set; }
    }
}