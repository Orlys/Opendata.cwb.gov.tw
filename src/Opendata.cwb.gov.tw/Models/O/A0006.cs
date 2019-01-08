
namespace Opendata.Models
{
    using System;
    using System.Collections.Generic;
    partial class O
    {
        /// <summary>
        /// 臭氧總量觀測資料
        /// </summary>
        public class A0006
        {

            public class Time
            {
                public DateTime? dataTime { get; set; }
                public string elementValue { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public List<Time> time { get; set; }
            }

            public class Location
            {
                public List<WeatherElement> weatherElement { get; set; }
                public string locationName { get; set; }
            }

            public class Records
            {
                public Location location { get; set; }
            }
        }

    }
}
