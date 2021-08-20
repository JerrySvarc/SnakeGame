using System;
using System.Collections.Generic;
using static System.Console;
namespace Snake
{
    class GameMap
    {
        private int sizeX;
        private int sizeY;
        public Map map;
        private Random rand = new Random();
        private Worm worm = new Worm();
        public List<MapTileWall> body = new List<MapTileWall>();
        public GameMap(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            map = new Map(sizeX, sizeY);
        }

        public void Render(long time)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {

                    SetCursorPosition(i, j);
                    map.GetTile(i, j).GetLetter().Write();
                }
            }
            ForegroundColor = ConsoleColor.White;
            Write("\n");
            Write("Length: " + (worm.growth + 1) + " " + "Time: " + (time / 1000) + "s");
        }

        public Map GetMap()
        {
            return map;
        }

        public void PlaceAtRandomFree(IMapTile tile)
        {
            while (true)
            {
                int x = rand.Next(1, sizeX - 1);
                int y = rand.Next(1, sizeY - 1);
                if (map.GetTile(x, y) == MapTile.EMPTY)
                {
                    map.SetTile(tile, x, y);
                    break;
                }

            }

        }

        public Worm GetWorm()
        {
            return worm;
        }

        public void DrawBorder()
        {
            for (int i = 0; i < sizeX; i++)
            {
                map.SetTile(MapTile.WALL, i, 0);
                map.SetTile(MapTile.WALL, i, sizeY - 1);
            }

            for (int i = 0; i < sizeY; i++)
            {
                map.SetTile(MapTile.WALL, 0, i);
                map.SetTile(MapTile.WALL, sizeX - 1, i);

            }
        }


        public void DrawEmpty()
        {
            for (int i = 1; i < sizeX - 1; i++)
            {
                for (int j = 1; j < sizeY - 1; j++)
                {
                    map.SetTile(MapTile.EMPTY, i, j);
                }
            }
        }



        public void Setup()
        {
            worm.SetHeading(Direction.RIGTH);
            DrawBorder();
            DrawEmpty();
            PlaceAtRandomFree(MapTile.FOOD);
            PlaceAtRandomFree(MapTile.WINE);
            PlaceAtRandomFree(MapTile.POISON);
            worm.SetHeadLocation(sizeX / 2, sizeY / 2);
            map.SetTile(MapTile.WORM_HEAD, worm.GetHeadLocation().x, worm.GetHeadLocation().y);

        }

    }
}
