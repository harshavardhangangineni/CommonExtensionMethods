using Extensions.Extensions;
using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hello = "The way      is to Long...........";
            DateTime time = DateTime.Now;
            Console.WriteLine(Hello.Captilise());
            Console.WriteLine(Hello.RemoveWhiteSpaces());
            Console.WriteLine(Hello.WordCount());
            Console.WriteLine(Hello.TrimAndReduce());
            Console.WriteLine(Hello.ToTitleCase());
            Console.WriteLine(time.ToAMPMFormat());
            Console.WriteLine(DateTime.Now.Yesterday());
            Console.WriteLine(DateTime.Now.Tommarow());
            Console.WriteLine(DateTime.Now.IsBetween(DateTime.Now.Yesterday(), DateTime.Now.Tommarow()));
            Console.WriteLine(DateTime.Now.AddDays(-2).FirstDayofWeek());
            Console.WriteLine(DateTime.Now.AddDays(-2).LastDayofWeek());
            Console.ReadLine();
        }
    }
}
