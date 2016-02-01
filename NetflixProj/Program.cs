using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie titanic = new Movie("Titanic", 9, 120);
            Movie actionMov = new Movie("action mov", 7, 100);
            Romance romancegenre = new Romance();
            Action actionGenre = new Action();
            actionGenre.movieInGenre.Add(actionMov);
            romancegenre.movieInGenre.Add(titanic);
            Episode one = new Episode(2);
            Episode two = new Episode(3);
            Episode three = new Episode(3);
            Episode four = new Episode(4);
            TV_Show One_Punch_man = new TV_Show();
            One_Punch_man.Episodes.Add(one);
            One_Punch_man.Episodes.Add(two);
            One_Punch_man.Episodes.Add(three);
            One_Punch_man.Episodes.Add(four);
            Genre actRom = actionGenre + romancegenre;



            Console.WriteLine(actRom.movieInGenre);
            View.Display(actRom);
            Console.ReadKey();
        }
    }
}
