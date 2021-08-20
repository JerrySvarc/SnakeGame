using System;
using System.Collections.Generic;

namespace Snake
{
    class Game
    {
        private int sizeX;
        private int sizeY;
        List<int> tailX = new List<int>();
        List<int> tailY = new List<int>();
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }

        public void Run()
        {
            Console.SetWindowSize(50, 31);
            Console.WriteLine("Size of the map on the x-axis? (max 50)");
            while (true)
            {
                bool input = int.TryParse(Console.ReadLine(), out int X);
                if (X > 1 && X <= 50 && input)
                {
                    this.sizeX = X;
                    break;
                }

                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("Size of the map on the y-axis? (max 30)");
            while (true)
            {
                bool input = int.TryParse(Console.ReadLine(), out int Y);
                if (Y > 1 && Y <= 30 && input)
                {
                    this.sizeY = Y;
                    break;
                }
                Console.WriteLine("Invalid input");
            }

            Console.Clear();
            Console.CursorVisible = false;
            GameMap gameMap = new GameMap(sizeX, sizeY);
            TimeDelta time = new TimeDelta();
            KeyboardController keyboard = new KeyboardController();

            gameMap.GetWorm().SetController(keyboard);
            gameMap.Setup();
            gameMap.Render(time.elapsedTime);

            while (gameMap.GetWorm().IsAlive())
            {
                time.Update();
                time.ElapsedTime();
                keyboard.Update();
                if (keyboard.GetInput() != null)
                {
                    gameMap.GetWorm().SetHeading(keyboard.GetInput());
                }
                if (time.DeltaTime() >= 350)
                {
                    time.CurrentTime();
                    Update(gameMap, keyboard, time);
                }

                if (gameMap.GetWorm().IsAlive() == false)
                {
                    break;
                }

            }
            Console.Clear();
            Console.WriteLine("GAME OVER!");
            Console.WriteLine("YOUR SCORE WAS: " + (gameMap.GetWorm().growth - 2));
            Console.ReadLine();
        }

        private void Update(GameMap gameMap, KeyboardController keyboard, TimeDelta time)
        {
            int wormheadX = gameMap.GetWorm().GetHeadLocation().x;
            int wormheadY = gameMap.GetWorm().GetHeadLocation().y;

            AddBody(gameMap, wormheadX, wormheadY);

            gameMap.GetWorm().Move();
            wormheadX = gameMap.GetWorm().GetHeadLocation().x;
            wormheadY = gameMap.GetWorm().GetHeadLocation().y;

            if (gameMap.map.GetTile(wormheadX, wormheadY) == MapTile.FOOD)
            {
                MapTile.FOOD.Chewed(gameMap.GetWorm());
                if (keyboard.reversed)
                {
                    keyboard.Reverse();
                }
                gameMap.PlaceAtRandomFree(MapTile.FOOD);
            }

            if (gameMap.map.GetTile(wormheadX, wormheadY) == MapTile.WINE)
            {
                if (keyboard.reversed == false)
                {
                    keyboard.Reverse();
                }
                MapTile.WINE.Chewed(gameMap.GetWorm());
                gameMap.PlaceAtRandomFree(MapTile.WINE);
            }

            if (gameMap.map.GetTile(wormheadX, wormheadY) == MapTile.POISON)
            {
                MapTile.POISON.Chewed(gameMap.GetWorm());
            }

            gameMap.map.SetTile(MapTile.WORM_HEAD, wormheadX, wormheadY);


            for (int i = 0; i < gameMap.body.Count; i++)
            {
                if (tailX[i] == wormheadX && tailY[i] == wormheadY)
                {
                    gameMap.GetWorm().Die();
                }
            }

            if (gameMap.body.Count > gameMap.GetWorm().growth)
            {
                gameMap.body.RemoveAt(0);
                gameMap.map.SetTile(MapTile.EMPTY, tailX[0], tailY[0]);
                tailX.RemoveAt(0);
                tailY.RemoveAt(0);
            }

            if (wormheadX == sizeX - 1 || wormheadX == 0 || wormheadY == sizeY - 1 || wormheadY == 0)
            {
                MapTile.WALL.Chewed(gameMap.GetWorm());
            }

            gameMap.Render(time.elapsedTime);
        }

        void AddBody(GameMap gameMap, int wormheadX, int wormheadY)
        {
            gameMap.body.Add(MapTile.WORM_BODY);
            tailX.Add(wormheadX);
            tailY.Add(wormheadY);
            gameMap.map.SetTile(MapTile.WORM_BODY, wormheadX, wormheadY);
        }
    }
}
