
namespace Opendata.cwb.gov.tw.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    partial class O
    {
        /// <summary>
        /// 自動氣象站-氣象觀測資料
        /// </summary>
        public class A0001
        {
            public class Time
            {
                public DateTime? obsTime { get; set; }
            }

            public class WeatherElement
            {
                public string elementName { get; set; }
                public string elementValue { get; set; }
            }

            public class Parameter
            {
                public string parameterName { get; set; }
                public string parameterValue { get; set; }
            }

            public class Location
            {
                public double? lat { get; set; }
                public double? lon { get; set; }
                public string locationName { get; set; }
                public string stationId { get; set; }
                public Time time { get; set; }
                public List<WeatherElement> weatherElement { get; set; }
                public List<Parameter> parameter { get; set; }
            }

            public class Records
            {
                public List<Location> location { get; set; }
            }
        }
    }
}
