using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.Classes
{
    public class TvShowDetail
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
        public ICollection<Creator> Created_By { get; set; }
        public ICollection<int> Episode_Run_Time { get; set; }
        public int MyProperty { get; set; }
        public ICollection<ValueDisplay> Genres { get; set; }
        public string Homepage { get; set; }
        public bool In_Production { get; set; }
        public ICollection<string> Languages { get; set; }
        public string Last_Air_Date { get; set; }
        public Episode Last_Episode_To_Air { get; set; }
        public Episode? Next_Episode_To_Air { get; set; }
        public ICollection<Network> Networks { get; set; }
        public int Number_Of_Episodes { get; set; }
        public int Number_Of_Seasons { get; set; }
        public ICollection<ProductionCompany> Production_Companies { get; set; }
        public ICollection<ProductionCountry> Production_Countries { get; set; }
        public ICollection<Season> Seasons { get; set; }
        public ICollection<SpokenLanguage> Spoken_Languages { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Type { get; set; }
    }
}
