
namespace Opendata.Core
{ 
    using Opendata.Models;
    using System.ComponentModel;

    /// <summary>
    /// 查詢用物件，詳見 https://opendata.cwb.gov.tw/dist/opendata-swagger.html
    /// </summary>
    public static class QueryBy
    {

        #region C
        /// <summary>
        /// 每日雨量-局屬地面測站每日雨量資料
        /// </summary>
        [Description("每日雨量-局屬地面測站每日雨量資料")]
        public static readonly By<C.B0025.Records> C_B0025_001 = new By<C.B0025.Records>(nameof(C_B0025_001));
        #endregion

        #region E
        /// <summary>
        /// 海嘯資訊資料-海嘯資訊資料
        /// </summary>
        [Description("海嘯資訊資料-海嘯資訊資料")]
        public static readonly By<E.A0014.Records> E_A0014_001 = new By<E.A0014.Records>(nameof(E_A0014_001));
        /// <summary>
        /// 顯著有感地震報告資料-顯著有感地震報告
        /// </summary>
        [Description("顯著有感地震報告資料-顯著有感地震報告")]
        public static readonly By<E.A0015.Records> E_A0015_001 = new By<E.A0015.Records>(nameof(E_A0015_001));
        /// <summary>
        /// 小區域有感地震報告資料-小區域有感地震報告
        /// </summary>
        [Description("小區域有感地震報告資料-小區域有感地震報告")]
        public static readonly By<E.A0016.Records> E_A0016_001 = new By<E.A0016.Records>(nameof(E_A0016_001));
        #endregion

        #region F
        /// <summary>
        /// 一般天氣預報-今明 36 小時天氣預報
        /// </summary>
        [Description("一般天氣預報-今明 36 小時天氣預報")]
        public static readonly By<F.C0032.Records> F_C0032_001 = new By<F.C0032.Records>(nameof(F_C0032_001));

        /// <summary>
        /// 鄉鎮天氣預報-宜蘭縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-宜蘭縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_001 = new By<F.D0047.Records>(nameof(F_D0047_001));
        /// <summary>
        /// 鄉鎮天氣預報-宜蘭縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-宜蘭縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_003 = new By<F.D0047.Records>(nameof(F_D0047_003));


        /// <summary>
        /// 鄉鎮天氣預報-桃園市未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-桃園市未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_005 = new By<F.D0047.Records>(nameof(F_D0047_005));
        /// <summary>
        /// 鄉鎮天氣預報-桃園市未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-桃園市未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_007 = new By<F.D0047.Records>(nameof(F_D0047_007));


        /// <summary>
        /// 鄉鎮天氣預報-新竹縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-新竹縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_009 = new By<F.D0047.Records>(nameof(F_D0047_009));
        /// <summary>
        /// 鄉鎮天氣預報-新竹縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-新竹縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_011 = new By<F.D0047.Records>(nameof(F_D0047_011));


        /// <summary>
        /// 鄉鎮天氣預報-苗栗縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-苗栗縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_013 = new By<F.D0047.Records>(nameof(F_D0047_013));
        /// <summary>
        /// 鄉鎮天氣預報-苗栗縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-苗栗縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_015 = new By<F.D0047.Records>(nameof(F_D0047_015));


        /// <summary>
        /// 鄉鎮天氣預報-彰化縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-彰化縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_017 = new By<F.D0047.Records>(nameof(F_D0047_017));
        /// <summary>
        /// 鄉鎮天氣預報-彰化縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-彰化縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_019 = new By<F.D0047.Records>(nameof(F_D0047_019));


        /// <summary>
        /// 鄉鎮天氣預報-南投縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-南投縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_021 = new By<F.D0047.Records>(nameof(F_D0047_021));
        /// <summary>
        /// 鄉鎮天氣預報-南投縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-南投縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_023 = new By<F.D0047.Records>(nameof(F_D0047_023));


        /// <summary>
        /// 鄉鎮天氣預報-雲林縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-雲林縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_025 = new By<F.D0047.Records>(nameof(F_D0047_025));
        /// <summary>
        /// 鄉鎮天氣預報-雲林縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-雲林縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_027 = new By<F.D0047.Records>(nameof(F_D0047_027));


        /// <summary>
        /// 鄉鎮天氣預報-嘉義縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-嘉義縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_029 = new By<F.D0047.Records>(nameof(F_D0047_029));
        /// <summary>
        /// 鄉鎮天氣預報-嘉義縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-嘉義縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_031 = new By<F.D0047.Records>(nameof(F_D0047_031));


        /// <summary>
        /// 鄉鎮天氣預報-屏東縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-屏東縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_033 = new By<F.D0047.Records>(nameof(F_D0047_033));
        /// <summary>
        /// 鄉鎮天氣預報-屏東縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-屏東縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_035 = new By<F.D0047.Records>(nameof(F_D0047_035));


        /// <summary>
        /// 鄉鎮天氣預報-臺東縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺東縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_037 = new By<F.D0047.Records>(nameof(F_D0047_037));
        /// <summary>
        /// 鄉鎮天氣預報-臺東縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺東縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_039 = new By<F.D0047.Records>(nameof(F_D0047_039));


        /// <summary>
        /// 鄉鎮天氣預報-花蓮縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-花蓮縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_041 = new By<F.D0047.Records>(nameof(F_D0047_041));
        /// <summary>
        /// 鄉鎮天氣預報-花蓮縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-花蓮縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_043 = new By<F.D0047.Records>(nameof(F_D0047_043));


        /// <summary>
        /// 鄉鎮天氣預報-澎湖縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-澎湖縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_045 = new By<F.D0047.Records>(nameof(F_D0047_045));
        /// <summary>
        /// 鄉鎮天氣預報-澎湖縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-澎湖縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_047 = new By<F.D0047.Records>(nameof(F_D0047_047));


        /// <summary>
        /// 鄉鎮天氣預報-基隆縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-基隆縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_049 = new By<F.D0047.Records>(nameof(F_D0047_049));
        /// <summary>
        /// 鄉鎮天氣預報-基隆縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-基隆縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_051 = new By<F.D0047.Records>(nameof(F_D0047_051));

        /// <summary>
        /// 鄉鎮天氣預報-新竹市未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-新竹市未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_053 = new By<F.D0047.Records>(nameof(F_D0047_053));
        /// <summary>
        /// 鄉鎮天氣預報-新竹市未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-新竹市未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_055 = new By<F.D0047.Records>(nameof(F_D0047_055));


        /// <summary>
        /// 鄉鎮天氣預報-嘉義市未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-嘉義市未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_057 = new By<F.D0047.Records>(nameof(F_D0047_057));
        /// <summary>
        /// 鄉鎮天氣預報-嘉義市未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-嘉義市未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_059 = new By<F.D0047.Records>(nameof(F_D0047_059));


        /// <summary>
        /// 鄉鎮天氣預報-臺北市未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺北市未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_061 = new By<F.D0047.Records>(nameof(F_D0047_061));
        /// <summary>
        /// 鄉鎮天氣預報-臺北市未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺北市未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_063 = new By<F.D0047.Records>(nameof(F_D0047_063));


        /// <summary>
        /// 鄉鎮天氣預報-高雄市未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-高雄市未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_065 = new By<F.D0047.Records>(nameof(F_D0047_065));
        /// <summary>
        /// 鄉鎮天氣預報-高雄市未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-高雄市未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_067 = new By<F.D0047.Records>(nameof(F_D0047_067));


        /// <summary>
        /// 鄉鎮天氣預報-新北市未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-新北市未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_069 = new By<F.D0047.Records>(nameof(F_D0047_069));
        /// <summary>
        /// 鄉鎮天氣預報-新北市未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-新北市未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_071 = new By<F.D0047.Records>(nameof(F_D0047_071));


        /// <summary>
        /// 鄉鎮天氣預報-臺中市未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺中市未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_073 = new By<F.D0047.Records>(nameof(F_D0047_073));
        /// <summary>
        /// 鄉鎮天氣預報-臺中市未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺中市未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_075 = new By<F.D0047.Records>(nameof(F_D0047_075));


        /// <summary>
        /// 鄉鎮天氣預報-臺南市未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺南市未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_077 = new By<F.D0047.Records>(nameof(F_D0047_077));
        /// <summary>
        /// 鄉鎮天氣預報-臺南市未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺南市未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_079 = new By<F.D0047.Records>(nameof(F_D0047_079));


        /// <summary>
        /// 鄉鎮天氣預報-連江縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-連江縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_081 = new By<F.D0047.Records>(nameof(F_D0047_081));
        /// <summary>
        /// 鄉鎮天氣預報-連江縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-連江縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_083 = new By<F.D0047.Records>(nameof(F_D0047_083));


        /// <summary>
        /// 鄉鎮天氣預報-金門縣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-金門縣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_085 = new By<F.D0047.Records>(nameof(F_D0047_085));
        /// <summary>
        /// 鄉鎮天氣預報-金門縣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-金門縣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_087 = new By<F.D0047.Records>(nameof(F_D0047_087));


        /// <summary>
        /// 鄉鎮天氣預報-臺灣未來 2 天天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺灣未來 2 天天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_089 = new By<F.D0047.Records>(nameof(F_D0047_089));
        /// <summary>
        /// 鄉鎮天氣預報-臺灣未來 1 週天氣預報
        /// </summary>
        [Description("鄉鎮天氣預報-臺灣未來 1 週天氣預報")]
        public static readonly By<F.D0047.Records> F_D0047_091 = new By<F.D0047.Records>(nameof(F_D0047_091));

        /// <summary>
        /// 潮汐預報-未來 1 個月潮汐預報
        /// </summary>
        [Description("潮汐預報-未來 1 個月潮汐預報")]
        public static readonly By<F.A0021.Records> F_A0021_001 = new By<F.A0021.Records>(nameof(F_A0021_001));
        #endregion

        #region O
        /// <summary>
        /// 自動氣象站-氣象觀測資料
        /// </summary>
        [Description("自動氣象站-氣象觀測資料")]
        public static readonly By<O.A0001.Records> O_A0001_001 = new By<O.A0001.Records>(nameof(O_A0001_001));
        /// <summary>
        /// 自動雨量站-雨量觀測資料
        /// </summary>
        [Description("自動雨量站-雨量觀測資料")]
        public static readonly By<O.A0002.Records> O_A0002_001 = new By<O.A0002.Records>(nameof(O_A0002_001));
        /// <summary>
        /// 局屬氣象站-現在天氣觀測報告
        /// </summary>
        [Description("局屬氣象站-現在天氣觀測報告")]
        public static readonly By<O.A0003.Records> O_A0003_001 = new By<O.A0003.Records>(nameof(O_A0003_001));
        /// <summary>
        /// 酸雨 pH 值-每日酸雨 pH 值
        /// </summary>
        [Description("酸雨 pH 值-每日酸雨 pH 值")]
        public static readonly By<O.A0004.Records> O_A0004_001 = new By<O.A0004.Records>(nameof(O_A0004_001));
        /// <summary>
        /// 紫外線指數-每日紫外線指數最大值
        /// </summary>
        [Description("紫外線指數-每日紫外線指數最大值")]
        public static readonly By<O.A0005.Records> O_A0005_001 = new By<O.A0005.Records>(nameof(O_A0005_001));
        /// <summary>
        /// 臭氧總量觀測資料-成功站
        /// </summary>
        [Description("臭氧總量觀測資料-成功站")]
        public static readonly By<O.A0006.Records> O_A0006_001 = new By<O.A0006.Records>(nameof(O_A0006_001));
        /// <summary>
        /// 臭氧總量觀測資料-臺北站
        /// </summary>
        [Description("臭氧總量觀測資料-臺北站")]
        public static readonly By<O.A0006.Records> O_A0006_002 = new By<O.A0006.Records>(nameof(O_A0006_002));
        /// <summary>
        /// 即時海況-潮位-沿岸潮位站監測資料
        /// </summary>
        [Description("即時海況-潮位-沿岸潮位站監測資料")]
        public static readonly By<O.A0017.Records> O_A0017_001 = new By<O.A0017.Records>(nameof(O_A0017_001));
        /// <summary>
        /// 即時海況-海象海溫-浮標站監測資料
        /// </summary>
        [Description("即時海況-海象海溫-浮標站監測資料")]
        public static readonly By<O.A0018.Records> O_A0018_001 = new By<O.A0018.Records>(nameof(O_A0018_001));
        /// <summary>
        /// 即時海況-海溫-浮標站與沿岸潮位站監測資料
        /// </summary>
        [Description("即時海況-海溫-浮標站與沿岸潮位站監測資料")]
        public static readonly By<O.A0019.Records> O_A0019_001 = new By<O.A0019.Records>(nameof(O_A0019_001));
        #endregion
    }
}
