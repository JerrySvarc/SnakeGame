namespace Snake
{
    public class MapTileWormKiller : MapTileBase
    {
        public ColoredLetter letter;
        public override void Chewed(Worm worm)
        {
            worm.Die();
        }

        public MapTileWormKiller(ColoredLetter letter) : base(letter)
        {
            this.letter = letter;
        }


    }
}
