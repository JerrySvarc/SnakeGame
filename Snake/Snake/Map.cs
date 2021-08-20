namespace Snake
{
    class Map
    {
        private int sizeX;
        private int sizeY;
        private IMapTile[,] map;

        public Map(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.map = new IMapTile[sizeX, sizeY];
        }

        public IMapTile GetTile(int x, int y)
        {
            return map[x, y];
        }

        public void SetTile(IMapTile tile, int x, int y)
        {
            map[x, y] = tile;
        }


    }
}
