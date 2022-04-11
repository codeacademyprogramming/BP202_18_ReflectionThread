using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLesson
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Thread thread1 = new Thread(ShowA);
            //Thread thread2 = new Thread(ShowB);

            //thread1.Start();
            //thread2.Start();

            // TPL
            //var task = ShowGoogleSrc().ContinueWith(x => Console.WriteLine("Bitdi"));

            //Console.WriteLine("Helllo Sun!");

            //Console.WriteLine("Helllo World!");

            //Console.WriteLine("Helllo Moon!");

            //Console.ReadLine();

            //=============================================
            //Async/Await

            var task =  GetGoogleSourceAsync();

            Console.WriteLine("salam");

            Console.ReadLine();
        }


        static Task ShowGoogleSrc()
        {
            HttpClient httpClient = new HttpClient();

            return Task.Run(() =>
            {
                Task<string> task = httpClient.GetStringAsync("https://google.com");
                var result = task.Result;

                Console.WriteLine(result);

            });
        }

        static async Task<string> GetGoogleSourceAsync()
        {
            HttpClient httpClient = new HttpClient();

            var src = await httpClient.GetStringAsync("https://google.com");

            return src;
        }

        static void ShowA()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write(" A");
            }
        }
        static void ShowB()
        {
            for (int i = 0; i< 10000; i++)
            {
                Console.Write(" B");

            }
        }
    }
}
