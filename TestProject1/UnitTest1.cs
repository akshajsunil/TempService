using TempService;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            temp t = new temp();
            double res = t.FTD(-40);
            Assert.Equal(-40, res);
            

        }
        [Fact]
        public void Test2()
        {
            temp t = new temp();
            
            double res2 = t.CFT(-40);
            Assert.Equal(-40, res2);

        }
    }
}