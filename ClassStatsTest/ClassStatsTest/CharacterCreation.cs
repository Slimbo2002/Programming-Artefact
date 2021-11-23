using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    enum Class
    {
        Marauder = 1,
        Assassin = 2,
        Thief = 3,
    }
    class CharacterCreator
    {
        string name;
        int age;
        Class role;
        Statisics playerStats = new Statisics();
        public void PlayerCreation()
        {
            bool mainLoop = true;
            while (mainLoop)
            {
                bool nameLoop = true;
                while (nameLoop)
                {
                    Console.WriteLine("What's your name?");
                    name = Console.ReadLine();
                    ;
                    Console.WriteLine($"Hello {name}! This is your name right?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "yes")
                    {
                        Console.WriteLine("Perfect, Onward!");
                        nameLoop = false;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Oh dear, forgot your name have you? Pity");
                    }
                    else
                    {
                        Console.WriteLine("Oh silly adventurer, thats not a name. Give it another go");

                    }
                }

                bool ageLoop = true;
                while (ageLoop)
                {
                    Console.WriteLine($"Now {name}, how old are you?");
                    string input = Console.ReadLine();
                    bool success = int.TryParse(input, out age);
                    if (success)
                    {
                        Console.WriteLine($"Are you sure you are {age} years old ");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "yes")
                        {
                            Console.WriteLine("Excellent, onto your class!");
                            ageLoop = false;
                        }
                        else if (answer == "no")
                        {
                            Console.WriteLine("Oh dear, Lets try again");
                        }
                        else
                        {
                            Console.WriteLine("I only need a yes or no, please stop getting distracted");
                        }


                    }
                    else
                    {
                        Console.WriteLine("I don't know if you're aware. Age is a number. Give it another go!");
                    }

                }

                bool classLoop = true;
                while (classLoop)
                {
                    Console.WriteLine("Time to pick your class, this will impact gameplay so make the right choice. \n1. Maurader \n2. Assassin \n3. Thief \nPlease enter number 1-3");
                    string input = Console.ReadLine();

                    int answer = Int32.Parse(input);

                    if (answer > 0 && answer < 4)
                    {
                        Class role = (Class)answer;

                        if (answer == 1)
                        {
                            Console.WriteLine("You have selected Maurauder, This will increase your power by 3 but decrease speed and stealth by 1");
                            
                            playerStats.Maurauder();
                            classLoop = false;

                        }

                    }
                    else
                    {
                        Console.WriteLine("Almdalf: Please stick to the guide. Its not that hard.");
                    }
                }

                mainLoop = false;
            }
            

            

        }



    }
}
