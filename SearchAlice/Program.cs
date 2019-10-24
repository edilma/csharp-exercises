using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Alice was beginning to get very tired of sitting" +
                " by her sister on the bank, and of having nothing to do: once or" +
                " twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is " +
                "the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("What word(s) you want to search for?  ");
            string searchValue = Console.ReadLine();

            bool foundIt = findTerm(paragraph, searchValue);

            if (foundIt == true)
            {
                Console.WriteLine("Your {0}, is in the Alice paragraph", searchValue);
            }
            else
            {
                Console.WriteLine("Sorry,your {0}, is NOT  in the Alice paragraph", searchValue);
            }






        }
        private static bool findTerm(string paragraph, string term)
        {
            bool answer = paragraph.Contains(term);
            return answer;
        }



    }
}
