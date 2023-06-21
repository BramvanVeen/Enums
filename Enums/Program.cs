using System;

namespace Enums
{
    internal class Program
        
    {
        enum Suits
        {
            Heart,     //0
            Diamond,   //1
            Club,      //2
            Spade      //3
        }
        static void DrawAce(Suits suit)
        {
            if (suit == Suits.Heart) 
            {
                Console.WriteLine($"╭───────╮");
                Console.WriteLine($"│A      │");
                Console.WriteLine($"│♥      │");
                Console.WriteLine($"│   ♥   │");
                Console.WriteLine($"│      ♥│");
                Console.WriteLine($"│      A│");
                Console.WriteLine($"╰───────╯");
                return; 
            }
            if (suit == Suits.Diamond)
            {
                Console.WriteLine($"╭───────╮");
                Console.WriteLine($"│A      │");
                Console.WriteLine($"│♦      │");
                Console.WriteLine($"│   ♦   │");
                Console.WriteLine($"│      ♦│");
                Console.WriteLine($"│      A│");
                Console.WriteLine($"╰───────╯");
                return;
            }
            if (suit == Suits.Club)
            {
                Console.WriteLine($"╭───────╮");
                Console.WriteLine($"│A      │");
                Console.WriteLine($"│♣      │");
                Console.WriteLine($"│   ♣   │");
                Console.WriteLine($"│      ♣│");
                Console.WriteLine($"│      A│");
                Console.WriteLine($"╰───────╯");
                return;
            }
            if (suit == Suits.Club)
                Console.WriteLine($"╭───────╮");
                Console.WriteLine($"│A      │");
                Console.WriteLine($"│♠      │");
                Console.WriteLine($"│   ♠   │");
                Console.WriteLine($"│      ♠│");
                Console.WriteLine($"│      A│");
                Console.WriteLine($"╰───────╯");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }
        static void Main(string[] args)
        {
            DrawAce(Suits.Heart);
        }
    }
}
