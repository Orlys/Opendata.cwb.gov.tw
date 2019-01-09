// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata.Models
{
    using System;
    using System.Collections.Generic;

    partial class E
    {
        /// <summary>
        /// 海嘯資訊資料-海嘯資訊資料
        /// </summary>
        public class A0014
        {
            public class Depth
            {
                public string unit { get; set; }
                public int value { get; set; }
            }

            public class EarthquakeInfo
            {
                public Depth depth { get; set; }
                public EpiCenter epiCenter { get; set; }
                public Magnitude magnitude { get; set; }
                public DateTime? originTime { get; set; }
                public string source { get; set; }
            }

            public class EpiCenter
            {
                public EpiCenterLat epiCenterLat { get; set; }
                public EpiCenterLon epiCenterLon { get; set; }
                public string location { get; set; }
            }

            public class EpiCenterLat
            {
                public string unit { get; set; }
                public double value { get; set; }
            }

            public class EpiCenterLon
            {
                public string unit { get; set; }
                public double? value { get; set; }
            }

            public class Magnitude
            {
                public double? magnitudeValue { get; set; }
            }

            public class Records
            {
                public string datasetDescription { get; set; }
                public List<Tsunami> tsunami { get; set; }
            }

            public class Tsunami
            {
                public EarthquakeInfo earthquakeInfo { get; set; }
                public string reportColor { get; set; }
                public string reportContent { get; set; }
                public int? reportNo { get; set; }
                public string reportType { get; set; }
                public int? tsunamiNo { get; set; }
                public string web { get; set; }
            }
        }
    }
}