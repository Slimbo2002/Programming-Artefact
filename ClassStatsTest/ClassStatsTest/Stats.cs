using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStatsTest
{
    class Statisics
    {


        //Base stats
        public static float speed;
        public static float power;
        public static float stealth;



        public void GetStats()
        {
            Console.WriteLine($"Speed: {speed} \nPower: {power} \nStealth: {stealth}");
        }
        
        public void Maurauder()
        {
            speed = 3;
            power = 8;
            stealth = 3;
        }
        
  
    }

}
