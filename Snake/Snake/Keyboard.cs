using System;

namespace Snake
{
    class Keyboard
    {
        private static Keyboard instance;
        private Keyboard() { }

        public static Keyboard Instance
        {
            get
            {
                if (instance == null)
                    instance = new Keyboard();
                return instance;
            }
        }

        public bool HasKey()
        {
            return Console.KeyAvailable;
        }

        public ConsoleKey? GetKey()
        {
            if (HasKey())
            {
                return Console.ReadKey(true).Key;
            }

            return null;
        }
    }
}
