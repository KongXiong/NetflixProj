using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProj
{
    public class TV_Show : Title
    {
        public List<Episode> Episodes = new List<Episode>();
        //public new int rating;
        public new int rating
        {
            get
            {
                int sum = 0;
                foreach(Episode name in Episodes)
                {
                    sum = sum + name.rating;
                }
                //rating = sum / Episodes.Count;
                return sum / Episodes.Count;
            }
            //set
            //{
            //}
        }
        public override string ToString()
        {
            return name + ":" + Episodes.Count + "episodes.";
        }
    }
}
