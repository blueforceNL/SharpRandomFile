using System;
using System.IO;
using System.Security.Cryptography;

namespace RandomFile
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args == null || args.Length == 0)
            {
                Console.WriteLine("No Input given, please enter Destination File Path and Size in Mb");
            }
            else
            {
                string filePath = args[0];
                int sizeInMb;
                if (int.TryParse(args[1], out sizeInMb))
                {
                    // Properly converted args[1] to an integer with the name of sizeInMb.
                }
                // Note: block size must be a factor of 1MB to avoid rounding errors
                const int blockSize = 1024 * 8;
                const int blocksPerMb = (1024 * 1024) / blockSize;

                byte[] data = new byte[blockSize];
                string message = $"Writing {sizeInMb}Mb to {filePath}";
                Console.WriteLine(message);

                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
                {
                    using (FileStream stream = File.OpenWrite(filePath))
                    {
                        for (int i = 0; i < sizeInMb * blocksPerMb; i++)
                        {
                            crypto.GetBytes(data);
                            stream.Write(data, 0, data.Length);
                        }
                    }
                }
                Console.WriteLine("Done writing!");
            }
        }
    }
}