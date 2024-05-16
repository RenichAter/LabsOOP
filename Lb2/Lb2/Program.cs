using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
class sync
{
    static void Main()
    {
        var timerForAll = new Stopwatch();
        Console.WriteLine("\nСинхронный запрос");
        string[] sites = { "https://readli.net/srch/?q=%D0%BB%D0%B0%D0%B2%D0%BA%D1%80%D0%B0%D1%84%D1%82", "https://flibusta.su/booksearch/?ask=%D0%BB%D0%B0%D0%B2%D0%BA%D1%80%D0%B0%D1%84%D1%82", "https://avidreaders.ru/s/%D0%BB%D0%B0%D0%B2%D0%BA%D1%80%D0%B0%D1%84%D1%82" };
        timerForAll.Start();
        for (int i = 0; i < sites.Length; i++)
        {
            var startTime = DateTime.Now;
            var client = new HttpClient();
            var Task = (client.GetAsync(sites[i]).Result.Content.ReadAsStringAsync().Result);
            File.WriteAllText("readli_lovecraft" + (i + 1) + ".json", Task);
            var endTime = DateTime.Now;
            Console.WriteLine("Время на запрос "+(i+1)+": " + (endTime - startTime));
        }
        timerForAll.Stop();
        Console.WriteLine("Общее время " + timerForAll.ElapsedMilliseconds + "ms");
  
    }
}