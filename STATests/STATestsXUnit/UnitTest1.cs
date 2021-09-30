using Avalonia;
using Xunit;

namespace STATestsXUnit
{
    public class UnitTest1
    {
        [UIFactAttribute]
        public void Test1()
        {
            AppBuilder.Configure<App>().UsePlatformDetect().SetupWithoutStarting();
        }
    }
}