using System;
using System.Diagnostics;

namespace BigONotationPartial
{
    class Exponential
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Exponential exponential = new Exponential();
            ExponentialExampleType exponentialExampleType = ExponentialExampleType.Fibonacci;
            switch (exponentialExampleType)
            {
                case ExponentialExampleType.Fibonacci:
                    int n = 80; //8 40 80
					exponential.Fibonacci(n);
					
					break;
            }
            Console.WriteLine("Time elapsed: {0:0.00} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();
        }

        /// Complexity: O(2^N)
        internal void Fibonacci(int n)
        {
			//n = 40;
            /*if (n < 0)
            {
                throw new Exception("n can not be less than zero");
            }
            if (n <= 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);*/
			/*return Fibonacci(n - 1);*/

			long a = 0;
			long b = 1;
			long aux = 0;


			for (int i = 0; i <= n; i++)
			{
				if (i == 0)
				{
					Console.WriteLine("fibonacci {0} = {1}", i, a);
				}
				else
				{
					aux = a;
					a = b;
					b = aux + a;
					Console.WriteLine("fibonacci {0} = {1}",i, a);
				}
			}
			
		}
    }
}
