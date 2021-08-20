namespace Snake
{
    public class Direction
    {
        private int dX;
        private int dY;

        public Direction(int dX, int dY)
        {
            this.dX = dX;
            this.dY = dY;
        }

        private static Direction up;
        private static Direction down;
        private static Direction left;
        private static Direction rigth;

        public static Direction UP
        {
            get
            {
                if (up == null)
                    up = new Direction(0, -1);
                return up;
            }

        }
        public static Direction DOWN
        {
            get
            {
                if (down == null)
                    down = new Direction(0, 1);
                return down;
            }

        }
        public static Direction LEFT
        {
            get
            {
                if (left == null)
                    left = new Direction(-1, 0);
                return left;
            }

        }
        public static Direction RIGTH
        {
            get
            {
                if (rigth == null)
                    rigth = new Direction(1, 0);
                return rigth;
            }

        }

        public int deltaX()
        {
            return dX;
        }

        public int deltaY()
        {
            return dY;
        }

    }
}
