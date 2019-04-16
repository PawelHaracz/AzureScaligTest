using System;
using System.Collections.Generic;
using System.Threading;

namespace TestCore
{
    public static class LongCalculation
    {
        public static void Run(int wait)
        {
            var n = 1024 ;
            var list = new List<object>();

            for (int i = 0; i < n; i++)
            {
                list.Add(new
                {
                    Iteration  = i,
                    Calculation = i/n
                });             
            }
            list.Clear();

        }
    }
}
