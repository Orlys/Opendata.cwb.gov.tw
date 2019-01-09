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
        /// 臭氧總量觀測資料
        /// </summary>
        public class A0006
        {
            public class Location
            {
                public string locationName { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class Records
            {
                public Location location { get; set; }
            }

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
        }
    }
}