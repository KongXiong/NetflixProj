using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProj
{
    public class Genre : IEnumerable
    {

        public List<Title> movieInGenre = new List<Title>();
        public IEnumerator GetEnumerator()
        {
            foreach (Title name in movieInGenre)
            {
                yield return name.name;
            }
           
        }
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre newGenre = new Genre();
            foreach (Title name in genre1.movieInGenre)
            {
                newGenre.movieInGenre.Add(name);
            }
            foreach (Title name in genre2.movieInGenre)
            {
                newGenre.movieInGenre.Add(name);
            }
            return newGenre;
        }
        public static Genre operator +(Genre genre1, Title title)
        {
            Genre newGenre = new Genre();
            foreach (Title name in genre1.movieInGenre)
            {
                newGenre.movieInGenre.Add(name);
            }
            foreach (Title name in genre1.movieInGenre)
            {
                if (name == title)
                {
                    newGenre.movieInGenre.Add(name);
                }
            }
            return newGenre;
        }
        
    }
}
