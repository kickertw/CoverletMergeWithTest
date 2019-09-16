using ClassLibrary1;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = new Class1().Method1();
            Assert.Equal(42, result);
        }
    }
}
