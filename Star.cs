using System;

namespace ConsoleStars
{
    public abstract class Star
    {
        private int _x;
        private int _y;

        protected Star(Random random)
        {
            _x = random.Next(1, Console.WindowWidth - 1);
            _y = random.Next(1, Console.WindowHeight - 1);
        }

        protected virtual char GetCharacter()
        {
            return '*';
        }

        public void Show()
        {
            Console.CursorLeft = _x;
            Console.CursorTop = _y;
            Console.Write(GetCharacter());
        }

        public abstract void Update();
    }
}
