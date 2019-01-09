// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata.Models
{
    using System;
    using System.Collections.Generic;

    partial class O
    {
        /// <summary>
        /// 自動氣象站-氣象觀測資料
        /// </summary>
        public class A0001
        {
            public class Location
            {
                public double? lat { get; set; }
                public string locationName { get; set; }
                public double? lon { get; set; }
                public List<Parameter> parameter { get; set; }
                public string stationId { get; set; }
                public Time time { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class Parameter
            {
                public string parameterName { get; set; }
                public string parameterValue { get; set; }
            }

            public class Records
            {
                public List<Location> location { get; set; }
            }

            public class Time
            {
                public DateTime? obsTime { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public string elementValue { get; set; }
            }
        }
    }
}