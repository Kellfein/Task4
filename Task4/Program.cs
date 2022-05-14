using System;

namespace Task4
{
    internal class Program
    {

        static void OutputOnNextLine(string[] x)
        {
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine($"\n {x[i]}");
        }

        static string[] Separator(string sentence)
        {
            string[] subs = sentence.Split(' ');
            return subs;
        }

        static string ReversWords(string inputPhrase)
        {
            string resultPhrase = " ";
            string[] phrase = Separator(inputPhrase);
            Array.Reverse(phrase);
            for (int i = 0; i < phrase.Length; i++)
            {
                resultPhrase += phrase[i] + " ";
            }
            return resultPhrase;
        }

        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine(" Введите предложение для разделения");
            string sentence = Console.ReadLine();
            string[] words = Separator(sentence);
            OutputOnNextLine(words);
            Console.ReadKey();

            // Задание 2
            Console.WriteLine(" Введите предложение для реверса");
            string inputPhrase = Console.ReadLine();
            string revSentese = ReversWords(inputPhrase);
            Console.WriteLine(revSentese);
            Console.ReadKey();
        }
    }
}
