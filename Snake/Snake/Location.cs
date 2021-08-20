namespace Snake
{
    public class Location
    {
        public int x;
        public int y;

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void SetX(int i)
        {
            x += i;
        }

        public void SetY(int i)
        {
            y += i;
        }
    }
}
