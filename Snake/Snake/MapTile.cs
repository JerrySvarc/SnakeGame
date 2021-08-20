using System;

namespace Snake
{
    public class MapTile
    {
        private static MapTileEdible food;
        private static MapTileWormKiller poison;
        private static MapTileWine wine;
        private static MapTileEmpty empty;
        private static MapTileWall wall;
        private static MapTileWall wormHead;
        private static MapTileWall wormBody;

        public static MapTileEdible FOOD
        {
            get
            {
                if (food == null)
                    food = new MapTileEdible(new ColoredLetter('■', ConsoleColor.Red));
                return food;
            }

        }
        public static MapTileWormKiller POISON
        {
            get
            {
                if (poison == null)
                    poison = new MapTileWormKiller(new ColoredLetter('■', ConsoleColor.Yellow));
                return poison;
            }

        }
        public static MapTileWine WINE
        {
            get
            {
                if (wine == null)
                    wine = new MapTileWine(new ColoredLetter('■', ConsoleColor.Magenta));
                return wine;
            }

        }
        public static MapTileEmpty EMPTY
        {
            get
            {
                if (empty == null)
                    empty = new MapTileEmpty(new ColoredLetter('■', ConsoleColor.Black));
                return empty;
            }

        }
        public static MapTileWall WALL
        {
            get
            {
                if (wall == null)
                    wall = new MapTileWall(new ColoredLetter('X', ConsoleColor.Red));
                return wall;
            }

        }
        public static MapTileWall WORM_HEAD
        {
            get
            {
                if (wormHead == null)
                    wormHead = new MapTileWall(new ColoredLetter('■', ConsoleColor.DarkRed));
                return wormHead;
            }

        }
        public static MapTileWall WORM_BODY
        {
            get
            {
                if (wormBody == null)
                    wormBody = new MapTileWall(new ColoredLetter('■', ConsoleColor.Green));
                return wormBody;
            }

        }
    }
}