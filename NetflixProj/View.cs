using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProj
{
    public class View
    {
        public static void Display(Genre genre)
        {
            Console.WriteLine(genre);
            foreach (Title name in genre.movieInGenre)
            {
                Console.WriteLine(name.name);
            }
        }
        
    
        
    }
}
