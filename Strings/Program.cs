using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing" +
                " to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, " +
                "'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Search term: ");
            string input = Console.ReadLine();
            int index = alice.ToLower().IndexOf(input.ToLower());
            if (index > -1)  
            {
                Console.WriteLine(input + " is located at index " + index + ". And has a length of " + input.Length);
                string newAlice = alice.Substring(0, index - 1) + alice.Substring(index + input.Length);
                Console.WriteLine(newAlice);
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
