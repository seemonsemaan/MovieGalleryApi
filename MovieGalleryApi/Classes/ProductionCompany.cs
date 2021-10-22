using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.Classes
{
    public class ProductionCompany
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string? Logo_Path { get; set; }
        public string Origin_Country { get; set; }
    }
}
