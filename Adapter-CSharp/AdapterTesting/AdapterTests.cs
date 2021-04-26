using Adapter_CSharp.BitcoinUSDAdapter;
using NUnit.Framework;

namespace AdapterTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBitcoinWithdraw()
        {
            Bitcoin bitcoin = new Bitcoin();

            double expected = 14.7;

            bitcoin.Withdraw(13.3);

            Assert.AreEqual(expected, bitcoin.GetBalance());


        }

        [Test]
        public void TestUSDWithdraw()
        {
            USDollars dollars = new USDollars();

            double expected = 99500;

            dollars.Withdraw(500);

            Assert.AreEqual(expected, dollars.GetBalance());
        }

        [Test]
        public void TestBitcoinDeposit()
        {
            Bitcoin bitcoin = new Bitcoin();

            double expected = 30.9;

            bitcoin.Deposit(2.9);

            Assert.AreEqual(expected, bitcoin.GetBalance());
        }

        [Test]
        public void TestUSDDeposit()
        {
            USDollars dollars = new USDollars();

            double expected = 100500;

            dollars.Deposit(500);

            Assert.AreEqual(expected, dollars.GetBalance());
        }

        [Test]
        public void TestBitAdapterBalance()
        {
            Bitcoin bitcoin = new Bitcoin();

            BitcoinToUSDollarsAdapter bitcoinAdapter = new BitcoinToUSDollarsAdapter(bitcoin);


            double expected = 28 * 48475.30;

            Assert.AreEqual(expected, bitcoinAdapter.GetBalance());
        }

        [Test]
        public void TestBitAdapterWithdraw()
        {
            Bitcoin bitcoin = new Bitcoin();

            BitcoinToUSDollarsAdapter bitcoinAdapter = new BitcoinToUSDollarsAdapter(bitcoin);

            var amount = 48475.30;

            bitcoinAdapter.Withdraw(amount);

            double expected = 27 * 48475.30;

            Assert.AreEqual(expected, bitcoinAdapter.GetBalance());
        }

        [Test]
        public void TestBitAdapterDeposit()
        {
            Bitcoin bitcoin = new Bitcoin();

            BitcoinToUSDollarsAdapter bitcoinAdapter = new BitcoinToUSDollarsAdapter(bitcoin);

            var amount = 48475.30;

            bitcoinAdapter.Deposit(amount);

            double expected = 29 * 48475.30;

            Assert.AreEqual(expected, bitcoinAdapter.GetBalance());
        }

        [Test]
        public void TestUSDAdapterBalance()
        {
            USDollars usd = new USDollars();

            USDollarToBitcoinAdapter usdAdapter = new USDollarToBitcoinAdapter(usd);

            double expected = 100000 / 48475.30;

            Assert.AreEqual(expected, usdAdapter.GetBalance());
        }

        [Test]
        public void TestUSDAdapterWithdraw()
        {
            USDollars usd = new USDollars();

            USDollarToBitcoinAdapter usdAdapter = new USDollarToBitcoinAdapter(usd);

            var amount = 1;

            usdAdapter.Withdraw(amount);

            double expected = (100000 - 48475.30) / 48475.30;

            Assert.AreEqual(expected, usdAdapter.GetBalance());
        }

        [Test]
        public void TestUSDAdapterDeposit()
        {
            USDollars usd = new USDollars();

            USDollarToBitcoinAdapter usdAdapter = new USDollarToBitcoinAdapter(usd);

            var amount = 1;

            usdAdapter.Deposit(amount);

            double expected = (100000 + 48475.30) / 48475.30;

            Assert.AreEqual(expected, usdAdapter.GetBalance());
        }

    }
}