using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SafeAutoKata
{
    class DAL
    {
        private string pathForFile;
        public DAL(string path)
        {
            pathForFile = path;
        }
        public List<Driver> drivers = new List<Driver>();
        public List<Trip> trips = new List<Trip>();


        public void AccessFile()
        {
            try
            {
                using (StreamReader str = new StreamReader(pathForFile))
                {
                    while (!str.EndOfStream)
                    {
                        string line = str.ReadLine();
                        if (line.Contains("Driver"))
                        {
                            List<string> tempData = new List<string>();
                            tempData.Add(line);
                            foreach (string name in tempData)
                            {
                                string subStr = name.Substring(7);
                                Driver driver = new Driver();
                                driver.Name = subStr;
                                drivers.Add(driver);
                            };//add new driver to system 
                        }

                        if (line.Contains("Trip"))
                        {
                            List<string> tempData = new List<string>();
                            tempData.AddRange(line.Split(' '));
                            Trip newTrip = new Trip();
                            newTrip.DriverName = tempData[1];//et driver name from file
                            newTrip.StartTime = Convert.ToDateTime(tempData[2]); //get start time from file 
                            newTrip.EndTime = Convert.ToDateTime(tempData[3]); //get end time from file
                            newTrip.Distance = Convert.ToDouble(tempData[4]); //get distance from file
                            trips.Add(newTrip);


                        }//add new trip to system

                    }
                }
                foreach (Trip trip in trips)
                {
                    foreach (Driver driver in drivers)
                    {
                        if (driver.Name == trip.DriverName)
                        {
                            driver.trips.Add(trip);
                            //add trip deatils to each driver 
                        }


                    }

                };
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }


    }
}
