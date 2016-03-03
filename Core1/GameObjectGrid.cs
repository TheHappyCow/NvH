using System;

namespace NvH_Core
{
#if WINDOWS || XBOX
    static class GameObjectGrid
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (GameObject game = new GameObject())
            {
                game.Run();
            }
        }
    }
#endif
}

