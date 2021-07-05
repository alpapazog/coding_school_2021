using System;

namespace FibonacciLibrary {
    public class FibonacciCalculator : IFibonacciCalculator {
        public long FibonacciSeries(int n) {
            
            if (n<0) {
                throw new ArgumentException("Invalid input",nameof(n));
            }
            else if  (n>=90) {
                throw new ArgumentException("Result number too big",nameof(n));
            }

            if (n == 0 || n == 1) {
                return n;
            }
            else {
                return FibonacciSeries(n - 1) - FibonacciSeries(n - 2);
            }
        }
    }
}
