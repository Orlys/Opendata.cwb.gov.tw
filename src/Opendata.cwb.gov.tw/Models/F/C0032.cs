
namespace Opendata.cwb.gov.tw.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    partial class F
    {
        /// <summary>
        /// 一般天氣預報-今明 36 小時天氣預報
        /// </summary>
        public class C0032
        {
            public class Parameter
            {
                public string parameterName { get; set; }
                public string parameterValue { get; set; }
                public string parameterUnit { get; set; }
            }

            public class Time
            {
                public DateTime? startTime { get; set; }
                public DateTime? endTime { get; set; }
                public Parameter parameter { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public List<Time> time { get; set; }
            }

            public class Location
            {
                public string locationName { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }

            public class Records
            {
                public string datasetDescription { get; set; }
                public List<Location> location { get; set; }
            }
        }
    }
}