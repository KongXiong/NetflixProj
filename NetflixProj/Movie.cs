using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProj
{
    class Movie : Title
    {
        List<string> list;
        double duration;
        public Movie(string name, int rating, double duration )
        {
            this.name = name;
            this.rating = rating;
            this.duration = duration;

        }
        public override string ToString()
        {
            return name + "  :  " + duration;
        }
    }
}
