using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.Classes
{
    public class Season
    {
        public string Air_Date { get; set; }
        public int Episode_Count { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public string Poster_Path { get; set; }
        public int Season_Number { get; set; }
    }
}
