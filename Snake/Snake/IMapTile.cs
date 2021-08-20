namespace Snake
{
    interface IMapTile
    {

        public ILetter GetLetter();
        void Chewed(Worm worm);

    }
}
