using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Movie
    {
        private string _title;
        private string _studio;
        public string Rating { get; private set; }

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            Rating = "PG";
        }

        public string ShowMovie()
        {
            return $"Movie: {_title} | Studio: {_studio} | Rating: {Rating}";
        }
    }
}
