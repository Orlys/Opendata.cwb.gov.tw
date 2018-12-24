
namespace Opendata.cwb.gov.tw.Models
{
    using System;
    using System.Collections.Generic;
    partial class O
    {
        /// <summary>
        /// 酸雨 pH 值-每日酸雨 pH 值 
        /// </summary>
        public class A0004
        {

            public class DatasetInfo
            {
                public string datasetDescription { get; set; }
            }

            public class Time
            {
                public DateTime? dataTime { get; set; }
                public string value { get; set; }
            }

            public class Parameter
            {
                public string parameterName { get; set; }
                public string parameterValue { get; set; }
                public string parameter { get; set; }
            }

            public class Location
            {
                public string locationName { get; set; }
                public List<Time> time { get; set; }
                public List<Parameter> parameter { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public List<Location> location { get; set; }
                public string month { get; set; }
            }

            public class Records
            {
                public DatasetInfo datasetInfo { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
            }
        }
    }
}