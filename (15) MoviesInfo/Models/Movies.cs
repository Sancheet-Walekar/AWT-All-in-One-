using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesInfo.Models
{
    public class Movies
    {
        public virtual int MoviesId { get; set; }
        public virtual String MoviesName { get; set; }
        public virtual String MoviesCategory { get; set; }
        public virtual float MoviesRatings { get; set; }
    }
}