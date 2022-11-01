using TaiwainStockUtility.TradingTime;

namespace Trading.Time.Test
{
    public class Tests
    {        
        [TestCase("2022/10/29 10:10:10")]//周6
        [TestCase("2022/10/29 8:10:10")]
        [TestCase("2022/10/30 10:10:10")]//週日
        [TestCase("2022/10/30 8:10:10")]
        public void TradeingTime_周末不開(string input)
        {
            DateTime dt= DateTime.Parse(input);
            var obj = new TaiwainStockUtilityCl();

            bool actual = obj.Input(dt).IsOpen;
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestCase("2022/10/28 10:10:10")]//周5
        public void TradeingTime_平日上班時間(string input)
        {
            DateTime dt = DateTime.Parse(input);
            var obj = new TaiwainStockUtilityCl();

            bool actual = obj.Input(dt).IsOpen;
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestCase("2022/10/28 8:10:10")]//周5
        [TestCase("2022/10/27 14:10:10")]//周4
        public void TradeingTime_平日下班時間(string input)
        {
            DateTime dt = DateTime.Parse(input);
            var obj = new TaiwainStockUtilityCl();

            bool actual = obj.Input(dt).IsOpen;
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}