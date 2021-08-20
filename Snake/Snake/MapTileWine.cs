namespace Snake
{
    public class MapTileWine : MapTileEdible
    {
        public ColoredLetter letter;


        public override void Chewed(Worm worm)
        {
            worm.growth += 4;
        }

        public MapTileWine(ColoredLetter letter) : base(letter)
        {
            this.letter = letter;
        }
    }
}
