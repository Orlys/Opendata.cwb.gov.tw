
namespace Opendata.Models
{
    using System;
    using System.Collections.Generic;
    partial class O
    {
        /// <summary>
        /// 即時海況-海象海溫-浮標站監測資料
        /// </summary>
        public class A0018
        {

            public class WeatherElement
            {
                public string elementName { get; set; }
                public string elementValue { get; set; }
            }

            public class Time
            {
                public DateTime? obsTime { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class Location
            {
                public string stationId { get; set; }
                public List<Time> time { get; set; }
            }

            public class Records
            {
                public List<Location> location { get; set; }
            }
        }
    }
        
}
