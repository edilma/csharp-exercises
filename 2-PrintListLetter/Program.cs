using System;

namespace _2_PrintListLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myLetters = {"R","I","A","N","O"};
            PrintLetters( myLetters);
        }

        public static void PrintLetters(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
    }
}
