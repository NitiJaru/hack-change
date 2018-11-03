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
            if (amount > pay)
            {
                return null;
            }

            // เงินที่ต้องทอนทั้งหมด
            var totalChange = pay - amount;

            // ตรวจสอบเงินที่ต้องทอน
            var change = totalChange;
            var thousandAmount = 0;
            var fiveHundredAmount = 0;
            var hundredAmount = 0;
            var fiftyAmount = 0;
            var twentyAmount = 0;
            var fiveAmount = 0;
            var oneAmount = 0;

            if (change >= 1000)
            {
                thousandAmount = change / 1000;
                change %= 1000;
            }
            if (change >= 500)
            {
                fiveHundredAmount = change / 500;
                change %= 500;
            }
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

            if (change >= 20)
            {
                twentyAmount = change / 20;
                change %= 20;
            }

            if (change >= 5)
            {
                fiveAmount = change / 5;
                change %= 5;
            }

            oneAmount = change;

            return new ChangeResponse()
            {
                Change = totalChange,
                ThousandAmount = thousandAmount,
                FiveHundredAmount = fiveHundredAmount,
                OneHundredAmount = hundredAmount,
                FiftyAmount = fiftyAmount,
                TwentyAmount = twentyAmount,
                FiveAmount = fiveAmount,
                OneAmount = oneAmount
            };
        }
    }
}
