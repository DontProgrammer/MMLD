
namespace MMLD.Core
{
    internal class Manager : IDisposable
    {
        FileManager fileManager;
        public bool Disposed { get; private set; }

        public Manager()
        {
        }

        public void ClearConsole()
        {

        }

        public void Dispose()
        {
            if(Disposed) return;
            Console.WriteLine("Manager disposing. Last close.");
            Disposed = true;
        }

        /// <summary>
        /// Animates the line 
        /// </summary>
        /// <param name="line">Line to animate</param>
        /// <param name="duration">Number in miliseconds</param>
        static internal void AnimateLine(string line, int duration = 30)
        {
            Thread thr = new Thread(() => {
                foreach (var item in line)
                {
                    Console.Write(item);
                    Thread.Sleep(duration);
                }
            })
            { Name = "Animate text" };
            thr.Start();

            while (thr.IsAlive)
            {
                Thread.Sleep(500);
            }
        }
    }
}
