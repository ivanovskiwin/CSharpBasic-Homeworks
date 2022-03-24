using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Please enter a string...");
            text = Console.ReadLine();
            text = text.Trim();
            Console.WriteLine($"Original string: {text}");
            FunWithStrings(text);
        }

        static void FunWithStrings(string text)
        {
            char[] letters = text.ToCharArray();
            //reversed string
            string reversed = "";
            for(int i=letters.Length-1; i>=0; i--)
            {
                reversed += letters[i];
            }
            Console.WriteLine($"Reversed string: {reversed}");

            //number of vowel
            int numberOfVowels = 0;
            char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            foreach(char letter in letters)
            {
                for(int i = 0; i<vowels.Length; i++)
                {
                    if (letter == vowels[i])
                    {
                        vowels[i] = '/';
                        numberOfVowels++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Number of vowels: {numberOfVowels}");

            //check if palindrome
            bool isPalindrome = text.ToLower()==reversed.ToLower() ? true : false;
            Console.WriteLine($"Is palindrome: {isPalindrome}");

            //Largest and smallest word
            string[] words = text.Split(' ');
            string largestWord = words[0];
            string smallestWord = words[0];
            foreach (string word in words)
            {
                if(word.Trim().Length > largestWord.Trim().Length && word.Trim().Length != 0)
                {
                    largestWord = word.Trim();
                }

                if (word.Trim().Length < smallestWord.Trim().Length && word.Trim().Length != 0)
                {
                    smallestWord = word.Trim();
                }
            }
            Console.WriteLine($"Largest word in the text: {largestWord}");
            Console.WriteLine($"Smallest word in the text: {smallestWord}");

            //print the count of words
            int numberOfWords = 0;
            foreach(string word in words)
            {
                if(word.Trim().Length != 0)
                {
                    numberOfWords++;
                }
            }
            Console.WriteLine($"This text has {numberOfWords} words.");

            //Most used character
            int[] charCount = new int[256];
            int length = letters.Length;
            for (int i = 0; i < length; i++)
            {
                if (letters[i] != ' ')
                {
                    charCount[letters[i]]++;
                }
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[letters[i]])
                {
                    maxCount = charCount[letters[i]];
                    character = letters[i];
                }
            }
            Console.WriteLine($"The charachter '{character}' occurs the most in the text. ({maxCount} times)");
        }
    }
}
