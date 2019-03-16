using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type something");
            string letters = Console.ReadLine().ToLower();
            var loopCount = 0;
            var myCharacters = new List<string>();

            foreach (var character in letters)
            {
                var letterString = character.ToString().ToUpper();
                letterString += new string(character, loopCount);

                myCharacters.Add(letterString);

                loopCount++;
            }

            Console.WriteLine(string.Join('-', myCharacters));
            Console.ReadLine();
        }
    }
}
