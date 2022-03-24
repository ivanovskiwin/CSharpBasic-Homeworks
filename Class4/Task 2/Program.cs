using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = " The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            Console.WriteLine($"{RemoveExtraSpaces(text.Trim())}");
        }

        static string RemoveExtraSpaces(string text)
        {
            string[] wordsArray = text.Split(' ');
            string cleanText = "";
            for(int i=0; i<wordsArray.Length; i++)
            {
                if(wordsArray[i].Trim().Length != 0)
                {
                    cleanText += wordsArray[i].Trim() + " ";
                }
            }
            return cleanText.Trim();
        }
    }
}
