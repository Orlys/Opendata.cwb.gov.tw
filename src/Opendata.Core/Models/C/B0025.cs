// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata.Models
{
    using System;
    using System.Collections.Generic;

    partial class C
    {
        /// <summary>
        /// 每日雨量-局屬地面測站每日雨量資料
        /// </summary>
        public class B0025
        {
            public class Location
            {
                public string locateChineseName { get; set; }
                public string locationName { get; set; }
                public string stationId { get; set; }
                public WeatherElement weatherElement { get; set; }
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
                public DateTime? dataTime { get; set; }
                public double? elementValue { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public Parameter parameter { get; set; }
                public List<Time> time { get; set; }
            }
        }
    }
}