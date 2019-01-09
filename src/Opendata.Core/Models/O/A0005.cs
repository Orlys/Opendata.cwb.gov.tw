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
        /// 紫外線指數-每日紫外線指數最大值
        /// </summary>
        public class A0005
        {
            public class Location
            {
                public string locationCode { get; set; }
                public double? value { get; set; }
            }

            public class Records
            {
                public WeatherElement weatherElement { get; set; }
            }

            public class Time
            {
                public DateTime? dataTime { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public List<Location> location { get; set; }
                public Time time { get; set; }
            }
        }
    }
}