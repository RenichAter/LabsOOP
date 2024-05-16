using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
class async
{
    static async Task Main()
    {
        var timerForAll = new Stopwatch();
        Console.WriteLine("\nАсинхронный запрос");
        string[] sites = { "https://readli.net/srch/?q=%D0%BB%D0%B0%D0%B2%D0%BA%D1%80%D0%B0%D1%84%D1%82", "https://flibusta.su/booksearch/?ask=%D0%BB%D0%B0%D0%B2%D0%BA%D1%80%D0%B0%D1%84%D1%82", "https://avidreaders.ru/s/%D0%BB%D0%B0%D0%B2%D0%BA%D1%80%D0%B0%D1%84%D1%82" };
        timerForAll.Start();
        //for (int i = 0; i < sites.Length; i++)
        //{
        //    var startTime = DateTime.Now;
        //    var client = new HttpClient();
        //    var Task = await client.GetAsync(sites[i]);
        //    File.WriteAllText("sites_lovecraft" + (i + 1) + ".json", Task.Content.ReadAsStringAsync().Result);
        //    var endTime = DateTime.Now;
        //    Console.WriteLine("Время на запрос " + (i + 1) + ": " + (endTime - startTime));
        //}
        var startTime1 = DateTime.Now;
        var client = new HttpClient();
        var Task = await client.GetAsync(sites[0]);
        File.WriteAllText("sites_lovecraft1.json", Task.Content.ReadAsStringAsync().Result);
        var endTime1 = DateTime.Now;
        Console.WriteLine("Время на запрос 1: " + (endTime1 - startTime1));

        var startTime2 = DateTime.Now;
        var Task2 = await client.GetAsync(sites[1]);
        File.WriteAllText("sites_lovecraft2.json", Task.Content.ReadAsStringAsync().Result);
        var endTime2 = DateTime.Now;
        Console.WriteLine("Время на запрос 2: " + (endTime2 - startTime2));

        var startTime3 = DateTime.Now;
        var Task3 = await client.GetAsync(sites[2]);
        File.WriteAllText("sites_lovecraft3.json", Task.Content.ReadAsStringAsync().Result);
        var endTime3 = DateTime.Now;
        Console.WriteLine("Время на запрос 3: " + (endTime3 - startTime3));

        timerForAll.Stop();
        Console.WriteLine("Общее время " + timerForAll.ElapsedMilliseconds + "ms");

    }
}