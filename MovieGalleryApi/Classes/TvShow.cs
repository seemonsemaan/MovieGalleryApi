using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.Classes
{
    public class TvShow
    {
        public string? Poster_Path { get; set; }
        public string Overview { get; set; }
        public ICollection<int> Genre_Ids { get; set; }
        public int Id { get; set; }
        public string Original_Language { get; set; }
        public string? Backdrop_Path { get; set; }
        public double Popularity { get; set; }
        public int Vote_Count { get; set; }
        public double Vote_Average { get; set; }
        public string First_Air_Date { get; set; }
        public ICollection<string> Origin_Country { get; set; }
        public string Name { get; set; }
        public string Original_Name { get; set; }
    }
}
