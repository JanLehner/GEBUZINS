namespace GebuZins.Tests
{
    using System.Windows.Forms;

    [TestClass]
    public class DatacheckerTest
    {
        private readonly Datachecker _datachecker = new Datachecker();
        private readonly TextBox textBox = new ();

        [TestMethod]
        public void CheckDataTest1()
        {
            textBox.Text = "Hello";

            _datachecker.CheckData(textBox);

            Assert.AreEqual(textBox.Text, string.Empty);
            Assert.AreEqual(textBox.SelectionStart, textBox.Text.Length);
        }

        [TestMethod]
        public void CheckDataTest2()
        {
            textBox.Text = "3,kdi3?0kd$8";

            _datachecker.CheckData(textBox);

            Assert.AreEqual(textBox.Text, "3308");
        }

        [TestMethod]
        public void CheckDataTest3()
        {
            textBox.Text = "3,kdi3.0kd8";

            _datachecker.CheckData(textBox);

            Assert.AreEqual(textBox.Text, "33.08");
        }

        [TestMethod]
        public void CheckDataTest4()
        {
            textBox.Text = "-2.25";

            _datachecker.CheckData(textBox);

            Assert.AreEqual(textBox.Text, "2.25");
        }

        [TestMethod]
        public void CheckDataTest5()
        {
            textBox.Text = "3548.45";

            _datachecker.CheckData(textBox);

            Assert.AreEqual(textBox.Text, "3548.45");
        }
    }
}
