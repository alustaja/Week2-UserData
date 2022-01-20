using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, siseta oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - YearOfBirth;
            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            //string interpolation - saab kirjutada täislauseid kuhu saab lisada muutujaid.

            Console.WriteLine($"Oled {userAge} aastat vana.");
        }
    }
}
