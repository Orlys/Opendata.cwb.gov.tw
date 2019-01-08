
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
            public class Depth
            {
                public double value { get; set; }
                public string unit { get; set; }
            }

            public class EpiCenterLat
            {
                public double value { get; set; }
                public string unit { get; set; }
            }

            public class EpiCenterLon
            {
                public string unit { get; set; }
                public double value { get; set; }
            }

            public class EpiCenter
            {
                public string location { get; set; }
                public EpiCenterLat epiCenterLat { get; set; }
                public EpiCenterLon epiCenterLon { get; set; }
            }

            public class Magnitude
            {
                public string magnitdueType { get; set; }
                public double magnitudeValue { get; set; }
            }

            public class EarthquakeInfo
            {
                public string originTime { get; set; }
                public string source { get; set; }
                public Depth depth { get; set; }
                public EpiCenter epiCenter { get; set; }
                public Magnitude magnitude { get; set; }
            }

            public class AreaIntensity
            {
                public int? value { get; set; }
                public string unit { get; set; }
            }

            public class Azimuth
            {
                public int? value { get; set; }
                public string unit { get; set; }
            }

            public class Distance
            {
                public string unit { get; set; }
                public double? value { get; set; }
            }

            public class Pga
            {
                public double? ewComponent { get; set; }
                public double? nsComponent { get; set; }
                public double? vComponent { get; set; }
                public string unit { get; set; }
            }

            public class StationIntensity
            {
                public int value { get; set; }
                public string unit { get; set; }
            }

            public class StationLat
            {
                public double? value { get; set; }
                public string unit { get; set; }
            }

            public class StationLon
            {
                public double? value { get; set; }
                public string unit { get; set; }
            }

            public class EqStation
            {
                public string stationName { get; set; }
                public string stationCode { get; set; }
                public string infoStatus { get; set; }
                public Azimuth azimuth { get; set; }
                public Distance distance { get; set; }
                public Pga pga { get; set; }
                public StationIntensity stationIntensity { get; set; }
                public StationLat stationLat { get; set; }
                public StationLon stationLon { get; set; }
            }

            public class ShakingArea
            {
                public string areaDesc { get; set; }
                public string areaName { get; set; }
                public string infoStatus { get; set; }
                public AreaIntensity areaIntensity { get; set; }
                public List<EqStation> eqStation { get; set; }
            }

            public class Intensity
            {
                public List<ShakingArea> shakingArea { get; set; }
            }

            public class Earthquake
            {
                public int? earthquakeNo { get; set; }
                public string reportType { get; set; }
                public string reportColor { get; set; }
                public string reportContent { get; set; }
                public Uri reportImageURI { get; set; }
                public string reportRemark { get; set; }
                public Uri web { get; set; }
                public EarthquakeInfo earthquakeInfo { get; set; }
                public Intensity intensity { get; set; }
            }

            public class Records
            {
                public string datasetDescription { get; set; }
                public List<Earthquake> earthquake { get; set; }
            }
        }
    }
}