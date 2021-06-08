using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.BusinessLayer
{
    public class Movie
    {
        // Represent Movie ID
        public int Id { get; set; }

        // Represent Movie Name
        public string MovieName { get; set; }

        // Represent Movie Description
        public string Description { get; set; }

        // Represent Movie Rating
        public float Rating { get; set; }

        // Represent Movie Platform ID
        public int PlatformID { get; set; }

        public Platform Platform { get; set; }

        // Represent Movie Director ID
        public int DirectorID { get; set; }

        public Director Director { get; set; }

        // Represent Movie Category ID
        public int CategoryID { get; set; }

        public Category Category { get; set; }


    }
}
