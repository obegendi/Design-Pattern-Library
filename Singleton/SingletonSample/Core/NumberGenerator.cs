using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample.Core
{
    public class NumberGenerator
    {
        public IEnumerable<long> Integers()
        {
            long currentValue = 1;
            while (true)
            {
                yield return currentValue++;
            }
        }
    }
}
