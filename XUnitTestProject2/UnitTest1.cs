using ClassLibrary2;
using System;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = new Class2().Method2();
            Assert.Equal(43, result);
        }
    }
}
