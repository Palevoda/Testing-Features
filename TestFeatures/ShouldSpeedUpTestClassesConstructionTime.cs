using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FeaturesData;

namespace TestFeatures
{
    //This class demonstrate how to speed up testing process. Constructor of LongTimeLoadedImitator 
    // contains Thread.Sleep(1000) to imitate long time loading. If i do not use interface IClassFixtue<..>
    // I will have 3 seconds time of testing. Now time 3ms.

    public class ShouldSpeedUpTestClassesConstructionTime : IClassFixture<LongTimeLoadedDataImitatorFixture>
    {
        private readonly LongTimeLoadedDataImitatorFixture _fixtue;

        public ShouldSpeedUpTestClassesConstructionTime(LongTimeLoadedDataImitatorFixture fixtue)
        {
            _fixtue = fixtue;
        }

        [Fact]
        public void TestOne()
        {
            Assert.Equal(1,1);
        }
        [Fact]
        public void TestTwo()
        {
            Assert.Equal(1, 1);
        }
        [Fact]
        public void TestThree()
        {
            Assert.Equal(1, 1);
        }
    }
}
