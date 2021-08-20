namespace Snake
{
    public class Worm
    {
        private IPlayerController controller;
        private bool isAlive = true;
        public int growth = 2;
        private Direction direction;
        private Location location;


        public void Move()
        {
            location.SetX(direction.deltaX());
            location.SetY(direction.deltaY());
        }

        public void Grow()
        {
            ++growth;
        }

        public void Die()
        {
            isAlive = false;
        }

        public bool IsAlive()
        {
            return isAlive;
        }

        IPlayerController GetController()
        {
            return controller;
        }

        public void SetController(IPlayerController c)
        {
            controller = c;
        }
        int GetGrowthCount()
        {
            return growth;
        }

        public void SetHeadLocation(int x, int y)
        {
            location = new Location(x, y);
        }

        public Location GetHeadLocation()
        {
            return location;
        }

        public Direction GetHeadDirection()
        {
            return direction;
        }

        public void SetHeading(Direction heading)
        {
            direction = heading;
        }




    }
}
