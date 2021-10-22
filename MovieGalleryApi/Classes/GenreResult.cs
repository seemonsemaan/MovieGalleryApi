using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.Classes
{
    public class GenreResult
    {
        public ICollection<ValueDisplay> Genres { get; set; }
    }
}
