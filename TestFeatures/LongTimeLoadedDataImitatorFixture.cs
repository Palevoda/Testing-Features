using FeaturesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFeatures
{
    public class LongTimeLoadedDataImitatorFixture : IDisposable
    {
        public LongTimeLoadedDataImitator State {get; private set;}

        public LongTimeLoadedDataImitatorFixture()
        {
            State = new LongTimeLoadedDataImitator();
        }

        public void Dispose()
        {

        }
    }
}
