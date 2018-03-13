using System;
using System.Collections.Generic;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System.Linq;
using Grasshopper;

namespace epoch_time_component
{
    public class convert_time
    {
        public convert_time(ref object d_in, ref object d_out, ref IGH_DataAccess DA)
        {
            if (d_in.GetType() == typeof(Grasshopper.Kernel.Types.GH_Time))
            {
                DateTime ht = new DateTime();
                DA.GetData(0, ref ht);
                d_out = ToEpoch(ht);
                return;
            }

            if (d_in.GetType() == typeof(Grasshopper.Kernel.Types.GH_String))
            {
                string et = "";
                DA.GetData(0, ref et);
                d_out = FromUnixTime(Convert.ToInt64(et));
                return;
            }
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