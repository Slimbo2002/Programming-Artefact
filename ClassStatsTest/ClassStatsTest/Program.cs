
using System;

namespace ClassStatsTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Statisics playerStats = new Statisics();
            CharacterCreator customPlayer = new CharacterCreator();

            Console.WriteLine("Almdalf: Greetings adventurer, I am Aldalf of Almdall, son of Almfall and father to Alm... you get it.");
            
            customPlayer.PlayerCreation();
            playerStats.GetStats();
            

            

        }
    }
}
