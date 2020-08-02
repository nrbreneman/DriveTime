using System;
using System.Collections.Generic;
using System.Text;

namespace SafeAutoKata
{
    public class Driver
    {
        public string Name { get; set; }
        public int MilesTraveled { get; set; }
        public int AverageSpeed { get; set; }
        public List<Trip> trips = new List<Trip>();

        public void getAverageSpeed()
        {
            double distance = 0;
            double timeTraveled = 0;
            int speed = 0;
            foreach (Trip trip in trips)
            {
                distance = trip.Distance + distance;
                timeTraveled = trip.getTimeInHours(trip.StartTime, trip.EndTime) + timeTraveled;
            }
            speed = Convert.ToInt32(distance / timeTraveled);
            if ((speed > 100) || (speed < 5))
            {
                AverageSpeed = 0;
            }
            else
            {
                AverageSpeed = speed;
            }

        }

        public void getDistanceTraveled()
        {
            int totalDistance = 0;
            foreach (Trip trip in trips)
            {
                totalDistance = Convert.ToInt32(totalDistance + trip.Distance);
            }
            MilesTraveled = totalDistance;
        }
    }
}

