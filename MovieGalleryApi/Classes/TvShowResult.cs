using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.Classes
{
    public class TvShowResult
    {
        public int Page { get; set; }
        public ICollection<TvShow> Results { get; set; }
        public int Total_Results { get; set; }
        public int Total_Pages { get; set; }
    }
}
