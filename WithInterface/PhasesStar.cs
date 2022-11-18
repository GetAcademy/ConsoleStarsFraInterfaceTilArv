using System;

namespace ConsoleStars.WithInterface
{
    public class PhasesStar : IStar
    {
        private const string _phaseChars = " .x*x.";
        private int _x;
        private int _y;
        private int _phaseIndex;

        public PhasesStar(Random random)
        {
            _x = random.Next(1, Console.WindowWidth - 1);
            _y = random.Next(1, Console.WindowHeight - 1);
            _phaseIndex = random.Next(0, _phaseChars.Length);
        }

        public void Show()
        {
            Console.CursorLeft = _x;
            Console.CursorTop = _y;
            Console.Write(_phaseChars[_phaseIndex]);
        }

        public virtual void Update()
        {
            _phaseIndex++;
            if (_phaseIndex == _phaseChars.Length) _phaseIndex = 0;
        }
    }
}
