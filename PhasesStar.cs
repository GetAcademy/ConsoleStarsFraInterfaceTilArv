using System;

namespace ConsoleStars
{
    public class PhasesStar : Star
    {
        private const string _phaseChars = " .x*x.";
        private int _phaseIndex;

        public PhasesStar(Random random)
            : base(random)
        {
            _phaseIndex = random.Next(0, _phaseChars.Length);
        }

        public override void Update()
        {
            _phaseIndex++;
            if (_phaseIndex == _phaseChars.Length) _phaseIndex = 0;
        }

        protected override char GetCharacter()
        {
            return _phaseChars[_phaseIndex];
        }
    }
}
