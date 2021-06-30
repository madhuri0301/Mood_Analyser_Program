using System;

namespace Mood_Analyser_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Mood Analyser Program");

            {
                // Taking Input For Mood
                Console.WriteLine("Enter message: ");
                string message = Console.ReadLine(); 
                MoodAnalyser checkmood = new MoodAnalyser(message);
                string result = checkmood.AnalyseMood(message);
                Console.WriteLine(result + " MOOD");
            }
        }
    }
}
