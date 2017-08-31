using System;
using Nancy.Hosting.Self;
using Flurl;
using Flurl.Http;

namespace dotnet_core_http_loop_example
{

    public class Example : Nancy.NancyModule
    {
        public Example()
        {
            Get("/{id}", args => $"Hello World {args.id}!");
        }
    }

    class Program
    {
        readonly string url = "http://127.0.0.1:1234";

        //
        static void Main(string[] args)
        {
            try {
                var program = new Program();
                using (var _=program.Server()) {
                    program.Client(args);
                }
            } catch (Exception e) {
                Console.WriteLine($"ERROR: {e}");
                System.Environment.Exit(1);
            }
        }


        //
        void Client(string[] args) {
            int runs = 10;
            if (args.Length>0)
            int.TryParse(args[0], out runs);

            for (int run =0; run<runs; run++) {
                System.Threading.Thread.Sleep(1000);
                var response = url
                    .AppendPathSegment($"{run}")
                    .GetStringAsync()
                    .Result;
                Console.WriteLine(response);
            }
        }

        //
        IDisposable Server() {
            var host = new NancyHost(new Uri(url));
            host.Start();
            Console.WriteLine($"Running on {url}");
            return host;
        }

    }
}
