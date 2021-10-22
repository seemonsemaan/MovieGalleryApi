using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieGalleryApi.Classes
{
    public class Creator
    {
        public int Id { get; set; }
        public string Credit_Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public string? Profile_Path { get; set; }
    }
}
