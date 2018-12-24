
namespace Opendata.cwb.gov.tw.Models
{
    using System;
    using System.Collections.Generic;
    partial class F
    {
        /// <summary>
        /// 鄉鎮天氣預報-未來2天/1週天氣預報
        /// </summary>
        public class D0047
        {

            public class ElementValue
            {
                public string value { get; set; }
                public string measures { get; set; }
            }

            public class Time
            {
                public DateTime? startTime { get; set; }
                public DateTime? endTime { get; set; }
                public List<ElementValue> elementValue { get; set; }
                public DateTime? dataTime { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public string description { get; set; }
                public List<Time> time { get; set; }
            }

            public class Location2
            {
                public string locationName { get; set; }
                public string geocode { get; set; }
                public double? lat { get; set; }
                public double? lon { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class Location
            {
                public string datasetDescription { get; set; }
                public string locationsName { get; set; }
                public string dataid { get; set; }
                public List<Location2> location { get; set; }
            }

            public class Records
            {
                public List<Location> locations { get; set; }
            }
        }
    }
}