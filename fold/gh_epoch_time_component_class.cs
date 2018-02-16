using System;
using System.Collections.Generic;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System.Linq;
using Grasshopper;

namespace gh_epoch_time_component
{
    public class gh_epoch_time
    {
        public string eT;
        public DateTime hT;


        public gh_epoch_time(string IepochTime, DateTime IhumanTime)
        {
            eT = ToEpoch(IhumanTime);
            hT = FromUnixTime(Convert.ToInt64(IepochTime));
        }


        public static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }

        public static string ToEpoch(DateTime humanTime)
        {
            return Convert.ToString((humanTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
        }

        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }

}

