using System;

namespace Snake
{
    public abstract class MapTileBase : IMapTile
    {
        public ConsoleColor foreground;
        public ConsoleColor background;
        public ColoredLetter letter;


        protected MapTileBase(ColoredLetter letter)
        {
            this.letter = letter;
        }


        public virtual void Chewed(Worm worm)
        {

        }

        public ILetter GetLetter()
        {

            return letter;
        }

    }
}
