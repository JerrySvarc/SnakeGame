namespace Snake
{
    public class MapTileWall : MapTileBase
    {
        public ColoredLetter letter;


        public override void Chewed(Worm worm)
        {
            worm.Die();
        }

        public MapTileWall(ColoredLetter letter) : base(letter)
        {
            this.letter = letter;
        }
    }
}
