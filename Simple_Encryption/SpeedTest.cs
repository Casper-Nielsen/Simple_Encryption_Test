using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Simple_Encryption
{
    class SpeedTest
    {
        /// <summary>
        /// Runs the test for both
        /// </summary>
        /// <param name="repeat">the amount of times it will be repeated</param>
        public void Run(int repeat)
        {
            Console.WriteLine("RNGCryptoServiceProvider");
            for (int i = 0; i < repeat; i++)
            {
                // Runs the RNGCryptoServiceProvider's test with 1000 cycles 
                Console.WriteLine(RNGCSP_Test(1000));
            }

            Console.WriteLine("Random");
            for (int i = 0; i < repeat; i++)
            {
                // Runs the Random's test with 1000 cycles
                Console.WriteLine(Random_Test(1000));
            }
        }

        /// <summary>
        /// Test RNGCryptoServiceProvider's speed for the given lenght
        /// </summary>
        /// <param name="lenght">the lenght of the test cycles</param>
        /// <returns>the amount of ticks it took</returns>
        private long RNGCSP_Test(int lenght)
        {
            Stopwatch stopwatch = new Stopwatch();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                int[] values = new int[lenght];
                byte[] bytes = new byte[4];
                // Starts the stopwatch
                stopwatch.Start();
                for (int i = 0; i < values.Length; i++)
                {
                    // Gets a random int
                    rng.GetBytes(bytes);
                    values[i] = BitConverter.ToInt32(bytes);
                }
                // Stops the stopwatch
                stopwatch.Stop();
                // Returns the time it took in Tick
                return stopwatch.ElapsedTicks;
            }
        }

        /// <summary>
        /// Test Random's speed for the given lenght
        /// </summary>
        /// <param name="lenght">the lenght of the test cycles</param>
        /// <returns>the amount of ticks it took</returns>
        private long Random_Test(int lenght)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rng = new Random();

            int[] values = new int[lenght];
            // Starts the stopwatch
            stopwatch.Start();
            for (int i = 0; i < values.Length; i++)
            {
                // Gets a random int
                values[i] = rng.Next(int.MinValue, int.MaxValue); ;
            }
            // Stops the stopwatch
            stopwatch.Stop();
            // Returns the time it took in Tick
            return stopwatch.ElapsedTicks;
        }
    }
}
