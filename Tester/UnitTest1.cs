using System.Security.Principal;

namespace Tester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            //Frodes eksempel
            //Assert.Throws<ArgumentException>(() => new Account().DepositEx(amount));// {})
        }
    }
}