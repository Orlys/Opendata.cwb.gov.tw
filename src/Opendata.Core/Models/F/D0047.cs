// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata.Models
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
                public string measures { get; set; }
                public string value { get; set; }
            }

            public class Location
            {
                public string dataid { get; set; }
                public string datasetDescription { get; set; }
                public List<Location2> location { get; set; }
                public string locationsName { get; set; }
            }

            public class Location2
            {
                public string geocode { get; set; }
                public double? lat { get; set; }
                public string locationName { get; set; }
                public double? lon { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class Records
            {
                public List<Location> locations { get; set; }
            }

            public class Time
            {
                public DateTime? dataTime { get; set; }
                public List<ElementValue> elementValue { get; set; }
                public DateTime? endTime { get; set; }
                public DateTime? startTime { get; set; }
            }

            public class WeatherElement
            {
                public string description { get; set; }
                public string elementName { get; set; }
                public List<Time> time { get; set; }
            }
        }
    }
}