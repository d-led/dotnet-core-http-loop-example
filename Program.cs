using System;

namespace dotnet_core_http_loop_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int runs = 10;
            if (args.Length>0)
            int.TryParse(args[0], out runs);

            for (int run =0; run<runs; run++) {
                Console.WriteLine($"Hello World {run}!");
            }
        }
    }
}
