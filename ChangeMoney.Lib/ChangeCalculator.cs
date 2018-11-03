using System;

namespace ChangeMoney.Lib
{
    public class ChangeCalculator
    {
        // Lib
        /// <summary>
        /// ทอนเงิน
        /// </summary>
        /// <param name="amount">เงินที่ต้องจ่าย</param>
        /// <param name="pay">เงินที่รับ</param>
        /// <returns>เงินทอน</returns>
        public ChangeResponse Change(int amount, int pay)
        {
            // เงินที่ต้องทอนทั้งหมด
            var totalChange = pay - amount;

            // ตรวจสอบเงินที่ต้องทอน
            var change = totalChange;
            var hundredAmount = 0;
            var fiftyAmount = 0;
            if (change >= 100)
            {
                hundredAmount = change / 100;
                change %= 100;
            }
            if (change >= 50)
            {
                fiftyAmount = change / 50;
                change %= 50;
            }

           return new ChangeResponse()
            {
                Change = totalChange,
                OneHundredAmount = hundredAmount,
                FiftyAmount = fiftyAmount
            };
        }
    }
}
