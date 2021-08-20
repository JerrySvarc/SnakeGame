namespace Snake
{
    public interface IPlayerController
    {
        void Update();
        Direction? GetInput();
        bool IsEndGame();
        void Reverse();
    }
}
