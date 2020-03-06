using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
            string transportation = "";

            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");

            string vacationType = Console.ReadLine() ;

            if (vacationType == "musical")
            {
                destination = "New Orleans";
            }
            else if (vacationType == "tropical")
            {
                destination = "Beach Vacation In Mexico";
            }
            else { destination = "Whitewater Rafting the Grand Canyon"; }

            Console.WriteLine("How many are in your group?") ;

            string groupSize = Console.ReadLine() ;

            int var = Convert.ToInt32(groupSize);

            if (var <= 2)
            {
                transportation = "First Class";
            }
            else if (var <= 5)
            {
                transportation = "Helicopter";
            }
            else { transportation = "Charter"; }

            Console.WriteLine($"Since you're a group of {groupSize} going on a {vacationType}, you should take a {transportation} to a {destination}.") ;
        }
    }
}
