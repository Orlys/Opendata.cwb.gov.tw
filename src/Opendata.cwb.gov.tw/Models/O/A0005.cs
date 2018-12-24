
namespace Opendata.cwb.gov.tw.Models
{
    using System;
    using System.Collections.Generic;
    partial class O
    {
        /// <summary>
        /// 紫外線指數-每日紫外線指數最大值
        /// </summary>
        public class A0005
        {
            public class Time
            {
                public DateTime? dataTime { get; set; }
            }

            public class Location
            {
                public string locationCode { get; set; }
                public double? value { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public Time time { get; set; }
                public List<Location> location { get; set; }
            }

            public class Records
            {
                public WeatherElement weatherElement { get; set; }
            }
        }
    }
}
