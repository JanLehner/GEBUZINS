namespace GebuZins.Tests
{
    [TestClass]
    public class DataprocessorTest
    {
        private readonly Dataprocessor _dataprocessor = new Dataprocessor();

        [TestMethod]
        public void ProcessDataTest1()
        {
            decimal birthdayDate = 10;
            decimal wealthAmount = 10;
            decimal interestRate = 10;

            decimal[] results = new decimal[2];

            decimal amountPerDay = ((wealthAmount / 100) * interestRate) / 365;
            decimal amountToGet = amountPerDay * birthdayDate;
            decimal inputTax = (amountToGet / 100) * 35;

            results[0] = decimal.Round(amountToGet, 2);
            results[1] = decimal.Round(inputTax, 2);

            decimal[] value = _dataprocessor.ProcessData(birthdayDate, wealthAmount, interestRate);

            Assert.AreEqual(results[0], value[0]);
            Assert.AreEqual(results[1], value[1]);
            Assert.AreEqual(results.Length, value.Length);
        }

        [TestMethod]
        public void ProcessDataTest2()
        {
            decimal[] results = _dataprocessor.ProcessData(15, 1000, 2);

            Assert.AreEqual(results[0], Convert.ToDecimal(0.82));
            Assert.AreEqual(results[1], Convert.ToDecimal(0.29));
            Assert.AreEqual(results.Length, 2);
        }

        [TestMethod]
        public void ProcessDataTest3()
        {
            decimal[] results = _dataprocessor.ProcessData(1, 1000000, Convert.ToDecimal(1.5));

            Assert.AreEqual(results[0], Convert.ToDecimal(41.10));
            Assert.AreEqual(results[1], Convert.ToDecimal(14.38));
            Assert.AreEqual(results.Length, 2);
        }

        [TestMethod]
        public void ProcessDataTest4()
        {
            decimal[] results = _dataprocessor.ProcessData(31, Convert.ToDecimal(54029.35), Convert.ToDecimal(1.75));

            Assert.AreEqual(results[0], Convert.ToDecimal(80.30));
            Assert.AreEqual(results[1], Convert.ToDecimal(28.11));
            Assert.AreEqual(results.Length, 2);
        }
    }
}
