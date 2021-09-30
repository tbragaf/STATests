using System.Threading;
using NUnit.Framework;

//[assembly: Apartment(ApartmentState.STA)]
namespace STATests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}