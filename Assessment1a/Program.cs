using System;

namespace Assessment1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string word = Console.ReadLine();
            Console.WriteLine(CountVowels(word));
            Console.WriteLine(TooManyVowels(word));
        }

        public static bool IsVowel(char c)
        {
            string vowels = "aeiouAEIOU";
            if (vowels.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CountVowels(string str)
        {
            int count = 0;
            foreach (char letter in str)
            {
                if (IsVowel(letter))
                {
                    count++;
                }
            }
            return count;
        }

        public static string TooManyVowels(string str)
        {
            int count = CountVowels(str);
            if (count <= 4)
            {
                return "Too few vowels.";
            }
            else if (count > 4 && count <= 7)
            {
                return "Right amount of vowels.";
            }
            else
            {
                return "Too many vowels!";
            }
        }
    }
}
