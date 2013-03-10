using System;

namespace RIPXNAGame
{
#if WINDOWS || XBOX
    static class Program
    {

        static void Main(string[] args)
        {
            using (Kernel game = new Kernel())
            {
                game.Run();
            }
        }
    }
#endif
}

