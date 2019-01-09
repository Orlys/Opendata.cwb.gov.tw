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
        /// 小區域有感地震報告資料-小區域有感地震報告
        /// </summary>
        public class A0016
        {
            public class AreaIntensity
            {
                public string unit { get; set; }
                public int? value { get; set; }
            }

            public class Azimuth
            {
                public string unit { get; set; }
                public int? value { get; set; }
            }

            public class Depth
            {
                public string unit { get; set; }
                public double value { get; set; }
            }

            public class Distance
            {
                public string unit { get; set; }
                public double? value { get; set; }
            }

            public class Earthquake
            {
                public EarthquakeInfo earthquakeInfo { get; set; }
                public int? earthquakeNo { get; set; }
                public Intensity intensity { get; set; }
                public string reportColor { get; set; }
                public string reportContent { get; set; }
                public Uri reportImageURI { get; set; }
                public string reportRemark { get; set; }
                public string reportType { get; set; }
                public Uri web { get; set; }
            }

            public class EarthquakeInfo
            {
                public Depth depth { get; set; }
                public EpiCenter epiCenter { get; set; }
                public Magnitude magnitude { get; set; }
                public string originTime { get; set; }
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
                public double value { get; set; }
            }

            public class EqStation
            {
                public Azimuth azimuth { get; set; }
                public Distance distance { get; set; }
                public string infoStatus { get; set; }
                public Pga pga { get; set; }
                public string stationCode { get; set; }
                public StationIntensity stationIntensity { get; set; }
                public StationLat stationLat { get; set; }
                public StationLon stationLon { get; set; }
                public string stationName { get; set; }
            }

            public class Intensity
            {
                public List<ShakingArea> shakingArea { get; set; }
            }

            public class Magnitude
            {
                public string magnitdueType { get; set; }
                public double magnitudeValue { get; set; }
            }

            public class Pga
            {
                public double? ewComponent { get; set; }
                public double? nsComponent { get; set; }
                public string unit { get; set; }
                public double? vComponent { get; set; }
            }

            public class Records
            {
                public string datasetDescription { get; set; }
                public List<Earthquake> earthquake { get; set; }
            }

            public class ShakingArea
            {
                public string areaDesc { get; set; }
                public AreaIntensity areaIntensity { get; set; }
                public string areaName { get; set; }
                public List<EqStation> eqStation { get; set; }
                public string infoStatus { get; set; }
            }

            public class StationIntensity
            {
                public string unit { get; set; }
                public int value { get; set; }
            }

            public class StationLat
            {
                public string unit { get; set; }
                public double? value { get; set; }
            }

            public class StationLon
            {
                public string unit { get; set; }
                public double? value { get; set; }
            }
        }
    }
}