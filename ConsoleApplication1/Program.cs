using System;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var position = new { Latitude = 25, Longitude = 134 };
            var elapsedMs = 34;

            LoggerFactory.Logger.Information("Processed {@Position} in {Elapsed} ms.", position, elapsedMs);

            try
            {
               BadMethod();
            }
            catch (Exception ex)
            {
                LoggerFactory.Logger.Error(ex, "Murphy's Law");
            }

            Console.ReadLine();
        }

        static void BadMethod()
        {
            throw new Exception("Something went wrong !!");
        }
    }
}
