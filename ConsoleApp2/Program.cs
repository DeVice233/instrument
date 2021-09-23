using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string editword = "";
            bool hour = false;
            string text = "капец, 8 час.";
            Console.WriteLine(text);
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < words.Length;i++)
            {
                foreach (string word in words)
                {
                    if (word.Contains("час"))
                    {
                        hour = true;
                        continue;
                    }
                    if (word.Contains("мин"))
                    {
                        hour = true;
                        continue;
                    }
                    else i++;
                }
                if (hour)
                {
                    words[i] = "";
                    continue;
                }
            }
            foreach (string word in words)
            {
                if (word.All(char.IsDigit))
                {
                    if (hour)
                    {
                        editword = word;
                        break;
                    }
                }
            }
            calc(ref editword);
            words[1] = editword;
            text = string.Join(" ", words);
            Console.WriteLine(text);
            Console.ReadKey();
        }
        public static string calc(ref string word)
        {
            int word2 = int.Parse(word);
            word = (word2 * 60 * 60).ToString();
            return word;
        }
        
    }
}
