using System;
using System.Configuration;

namespace ConsoleApp
{
    public class Constant
    {
        public const int SpeedOfLight = 300000;
    }
    public class Mars
    {
        public readonly int DistanceToMars = 0;

        public Mars()
        {
            DistanceToMars = Convert.ToInt32(ConfigurationManager.AppSettings["DistanceToMars"]);
        }

        public int GetInfo()
        {
            return DistanceToMars / Constant.SpeedOfLight;
        }

    }

    public class Program
    {
       
        public static void Main(string[] args)
        {
            Mars mars = new Mars();
            Console.WriteLine($"The Speed of Light form earth to mars is approximately {mars.GetInfo()} Kilometers per Hour");

            Console.ReadKey();
        }
    }
}