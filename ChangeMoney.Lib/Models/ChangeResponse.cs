using System;

namespace ChangeMoney.Lib
{
    public class ChangeResponse
    {
        // เงินทอน
        public int Change { get; set; }
        // ทอนแบงค์ 1000
        public int ThousandAmount { get; set; }
        // ทอนแบงค์ 500
        public int FiveHundredAmount { get; set; }
        // ทอนแบงค์ 100
        public int OneHundredAmount { get; set; }
        // ทอนแบงค์ 50
        public int FiftyAmount { get; set; }
        // ทอนแบงค์ 20
        public int TwentyAmount { get; set; }
        // ทอนแบงค์ 5
        public int FiveAmount { get; set; }
        // ทอนแบงค์ 1
        public int OneAmount { get; set; }
    }
}