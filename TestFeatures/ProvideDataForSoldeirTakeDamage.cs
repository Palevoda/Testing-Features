using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFeatures
{
    public class ProvideDataForSoldeirTakeDamage
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                // If class contain a lot of data, it is also possible to parse data from .csv/.json/.xml 
                yield return new object[] { 0, 100 };
                yield return new object[] { 50, 50 };
                yield return new object[] { 100, 0 };
                yield return new object[] { 200, 0 };
            }           
        }
    }
}
