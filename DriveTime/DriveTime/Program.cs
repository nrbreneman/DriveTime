using System;

namespace SafeAutoKata
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:/users/nrbre/SafeAutoKata.txt
            Console.WriteLine("What is fully qualified name of the file that should be accessed?");
            string pathForFile = Console.ReadLine();
            DAL data = new DAL(pathForFile);
            data.AccessFile();
            Console.WriteLine();
            Console.WriteLine("The following are the results of the file that was input:");
            foreach (Driver driver in data.drivers)
            {

                driver.getDistanceTraveled();
                if (driver.MilesTraveled > 0)
                {
                    driver.getAverageSpeed();

                    Console.WriteLine(driver.Name + ": " + driver.MilesTraveled + " miles @ " + driver.AverageSpeed + "mph");
                }
                else
                {
                    Console.WriteLine(driver.Name + ": 0 miles");
                }

            }

            Console.ReadLine();

        }
    }
}
