using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FeaturesData
{
    public class LongTimeLoadedDataImitator
    {
        public LongTimeLoadedDataImitator()
        {
            Thread.Sleep(1000);
        }
    }
}
