using System;
using System.Collections.Generic;



namespace SpinningDiscs
{
   class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            

            DVD test_dvd = new DVD("Super Fast", 65, "Mary Poppins");
            CD test_cd = new CD("Kind of Fast", 36, "Lil wayne");

            // TODO: Call each CD and DVD method to verify that they work as expected.

            test_dvd.PlayMovie();
            test_dvd.SpinDisc();
            test_dvd.Read();
            test_cd.PlaySong();
            test_cd.SpinDisc();
            test_cd.Read();

        }
        
        
    }
}
