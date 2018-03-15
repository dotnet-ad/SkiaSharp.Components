using System;
using System.Net;
using System.Net.Sockets;

namespace SkiaSharp.Components.Markup.Live.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static async void Start()
        {
            try
            {
                var port = 81;
                var server = new LiveServer("/Users/alois/SkiaSharp.Components/src/SkiaSharp.Components.Samples", "*.skml");
                var t = server.StartAsync($"http://+:{port}/");
                Console.WriteLine($"Listening ws://{GetLocalIPAddress()}:{port}...");
                await t;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }

        public static string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}