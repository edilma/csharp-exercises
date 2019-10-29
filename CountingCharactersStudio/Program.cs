using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingCharactersStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
            "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
            "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet " +
            "suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac " +
            "suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            //to make case insensitive I change everything to uppercase
            texto = texto.ToUpper();
           

            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            
            foreach (char letter in texto)
            {
                if (Char.IsLetter(letter)) // Check if the character is a letter. 
                 {
                    if (characterCount.ContainsKey(letter))
                    {
                        characterCount[letter] = characterCount[letter] + 1;
                    }
                    else
                    {
                        characterCount.Add(letter, 1);
                    }
                }
            }

            printLetterOccurrences(characterCount);
           Console.ReadLine();


        }
        private static void printLetterOccurrences(Dictionary<char, int> characterCount)
        {
            StringBuilder myRoster = new StringBuilder();
            foreach (KeyValuePair<char, int> item in characterCount)
            {
                myRoster.Append(item.Key);
                myRoster.Append("\t");
                myRoster.Append(item.Value);
                myRoster.Append("\n");
            }
            Console.WriteLine(myRoster);
        }

    }
}
