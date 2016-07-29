using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class Class1
    {
        public static async Task<int> Add(int a, int b)
        {
            // Work for a while...
            await Task.Delay(0); // (Use TaskEx.Delay on VS2010)

            // Return the result
            return a + b;
        }


    }
}
