using System;
using System.Threading.Tasks;
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
        readonly string url = "http://localhost:1234";

        void Client(string[] args) {
            int runs = 10;
            if (args.Length>0)
            int.TryParse(args[0], out runs);

            FlurlHttp.Configure(c => {
                c.DefaultTimeout = TimeSpan.FromSeconds(30);
                });

            // create some requests and exit
            Task.Run(() =>
            {
                for (int run =0; run<runs; run++) {
                    System.Threading.Thread.Sleep(1000);
                    var response = url
                        .AppendPathSegment($"{run}")
                        .GetStringAsync()
                        .Result;
                    Console.WriteLine(response);
                }
                System.Environment.Exit(0);
                });
        }

        void Server() {
            using (var host = new NancyHost(new Uri(url)))
            {
                host.Start();
                Console.WriteLine($"Running on {url}");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            try {
                var program = new Program();
                program.Client(args);
                program.Server();
            } catch (Exception e) {
                Console.WriteLine($"ERROR: {e}");
                System.Environment.Exit(1);
            }
        }
    }
}
