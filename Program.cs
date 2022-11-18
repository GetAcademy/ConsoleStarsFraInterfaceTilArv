using System;
using System.Threading;

namespace ConsoleStars
{
    /*
     * Pause til 11:00
     *
     * Arv
     * 1: Fra interface til arv
     *  "is a"
     * 2: Ev. WPF
     */
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var stars = new Star[]
            {
                new PhasesStar(random),
                new PhasesStar(random),
                new PhasesStar(random),
                new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),
            };
            while (true)
            {
                Console.Clear();
                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(200);
            }
        }
    }
}
