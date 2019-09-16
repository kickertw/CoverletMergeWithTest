using ClassLibrary3;
using System;
using Xunit;

namespace XUnitTestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = new Class3().Method3();
            Assert.Equal(44, result);
        }
    }
}
