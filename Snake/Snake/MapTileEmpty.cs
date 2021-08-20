namespace Snake
{
    public class MapTileEmpty : MapTileBase
    {

        public ColoredLetter letter;

        public override void Chewed(Worm worm)
        {

        }

        public MapTileEmpty(ColoredLetter letter) : base(letter)
        {
            this.letter = letter;
        }
    }
}
