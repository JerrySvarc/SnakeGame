using System;

namespace Snake
{
    public class ColoredLetter : ILetter
    {

        char letter;
        ConsoleColor foreground;


        public ColoredLetter(char letter, ConsoleColor foreground)
        {
            this.letter = letter;
            this.foreground = foreground;

        }

        public void Write()
        {
            Console.ForegroundColor = foreground;
            Console.Write(letter);
        }
    }
}
