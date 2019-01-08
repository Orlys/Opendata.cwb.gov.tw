
namespace Opendata.Models
{
    using System;
    using System.Collections.Generic;
    partial class O
    {
        /// <summary>
        /// 即時海況-海溫-浮標站與沿岸潮位站監測資料
        /// </summary>
        public class A0019
        {

            public class WeatherElement
            {
                public string elementName { get; set; }
                public string elementValue { get; set; }
                public string elementMeasures { get; set; }
            }

            public class Time
            {
                public DateTime? obsTime { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class Location
            {
                public string locationName { get; set; }
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