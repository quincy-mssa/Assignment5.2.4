namespace Assignment5._2._4
{
    internal class Program
    {
        //Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
        //Test Data :
        //Input a string : RADAR
        //Expected Output :
        //The string is Palindrome
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if it is a palindrome:");
            string word = Console.ReadLine();

            if (IsPalindrome(word))
            {
                Console.WriteLine($"The word {word} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The word {word} is not a palindrome.");
            }
        }

        static bool IsPalindrome(string word)
        {
            if (word.Length <= 1)
            {
                return true;
            }

            if (word[0] != word[word.Length - 1])
            {
                return false;
            }

            string shorterWord = word.Substring(1, word.Length - 2);
            return IsPalindrome(shorterWord);
        }
    }
}

