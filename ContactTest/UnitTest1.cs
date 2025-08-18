using BenchmarkDotNet.Running;

namespace ContactTest
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            AddOperationTest addTest= new AddOperationTest();
            int a = 2,b=3;

            int actual = addTest.Add(a, b);

            int expected = 5;

            Assert.Equal(expected, actual);
        }
    }
}
