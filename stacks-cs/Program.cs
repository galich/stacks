using System;
using System.Threading;
using System.Threading.Tasks;

namespace stacks_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () => {
                try {
                    await ProcessMany();
                }
                catch(Exception e) {
                    Console.WriteLine(e);
                }
            }).Wait();
        }

        static async Task ProcessMany() {
            await ProcessOne();
        }

        static async Task ProcessOne() {
            await Task.Delay(100);
            throw new Exception("something bad happened here");
        }
    }
}
