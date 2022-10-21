using TempService;

namespace NunitTest
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
            temp t = new temp();
            double  res=t.FTD(-40);
            Assert.AreEqual(-40,res);
        }
        [Test]
        public void Test2()
        {
            temp t = new temp();
            double res = t.CFT(-40);
            Assert.AreEqual(-40, res);
        }
    }
}