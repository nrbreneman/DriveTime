using System;
using System.Collections.Generic;
using System.Text;

namespace SafeAutoKata
{
    public class Trip
    {
        public string DriverName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Distance { get; set; }

        public double getTimeInHours (DateTime startTime, DateTime endTime)
        {
            double totalTime = 0;
            TimeSpan ts = endTime - startTime;
            totalTime = Convert.ToDouble(ts.TotalHours);
            return totalTime;
        }
    }
}
