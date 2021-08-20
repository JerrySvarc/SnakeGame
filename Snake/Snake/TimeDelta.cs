using System.Diagnostics;

namespace Snake
{
    class TimeDelta
    {
        Stopwatch sw = Stopwatch.StartNew();
        public long lastTime = 0;
        public long currentTime = 0;
        public long elapsedTime = 0;

        public void Update()
        {
            currentTime = sw.ElapsedMilliseconds;

        }

        public void CurrentTime()
        {
            lastTime = currentTime;
        }

        public long DeltaTime()
        {
            return currentTime - lastTime;
        }

        public void ElapsedTime()
        {
            elapsedTime = sw.ElapsedMilliseconds;
        }
    }
}
