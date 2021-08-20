namespace Snake
{
    public class MapTileEdible : MapTileBase
    {

        public ColoredLetter letter;



        int GetCalories()
        {
            return 0;
        }

        public override void Chewed(Worm worm)
        {
            worm.growth += 1;
        }

        public MapTileEdible(ColoredLetter letter) : base(letter)
        {
            this.letter = letter;
        }
    }
}
