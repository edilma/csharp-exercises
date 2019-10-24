using System;

namespace _2_PrintListLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayValues = { 1,1,2,3,5,8 };
            PrintArrayValues(arrayValues);
        }
        
        private static void PrintArrayValues(int[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
            }
        }
        
    }
}
