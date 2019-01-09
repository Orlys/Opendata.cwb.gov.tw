// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata.Models
{
    using System;
    using System.Collections.Generic;

    partial class F
    {
        public class A0021
        {
            public class Location
            {
                public string locationName { get; set; }
                public string stationId { get; set; }
                public List<ValidTime> validTime { get; set; }
            }

            public class Parameter
            {
                public string parameterMeasure { get; set; }
                public string parameterName { get; set; }
                public string parameterValue { get; set; }
            }

            public class Records
            {
                public string dataid { get; set; }
                public List<Location> location { get; set; }
                public string note { get; set; }
            }

            public class Time
            {
                public DateTime? dataTime { get; set; }
                public List<Parameter> parameter { get; set; }
            }

            public class ValidTime
            {
                public DateTime? endTime { get; set; }
                public DateTime? startTime { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public string elementValue { get; set; }
                public List<Time> time { get; set; }
            }
        }
    }
}