
namespace Opendata.cwb.gov.tw.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    partial class E
    {

        /// <summary>
        /// 海嘯資訊資料-海嘯資訊資料
        /// </summary>
        public class A0014
        {
            public class Depth
            {
                public int value { get; set; }
                public string unit { get; set; }
            }

            public class EpiCenterLat
            {
                public double value { get; set; }
                public string unit { get; set; }
            }

            public class EpiCenterLon
            {
                public double? value { get; set; }
                public string unit { get; set; }
            }

            public class EpiCenter
            {
                public string location { get; set; }
                public EpiCenterLat epiCenterLat { get; set; }
                public EpiCenterLon epiCenterLon { get; set; }
            }

            public class Magnitude
            {
                public double? magnitudeValue { get; set; }
            }

            public class EarthquakeInfo
            {
                public DateTime? originTime { get; set; }
                public Depth depth { get; set; }
                public EpiCenter epiCenter { get; set; }
                public Magnitude magnitude { get; set; }
                public string source { get; set; }
            }

            public class Tsunami
            {
                public string reportColor { get; set; }
                public string reportContent { get; set; }
                public int? reportNo { get; set; }
                public string reportType { get; set; }
                public int? tsunamiNo { get; set; }
                public string web { get; set; }
                public EarthquakeInfo earthquakeInfo { get; set; }
            }

            public class Records
            {
                public string datasetDescription { get; set; }
                public List<Tsunami> tsunami { get; set; }
            }
        }
    }
}