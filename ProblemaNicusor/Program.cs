using System.Numerics;

namespace ProblemaNicusor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var found = false;
            var numOfDigits = 4;

            while (!found)
            {
                var target = (BigInteger)Math.Pow(10, numOfDigits) - 2;

                for (var i = 1; i <= 9 && !found; i++)
                {
                    if (target * i % 19 == 0)
                    {
                        var partialResult = target * i / 19;
                        var result = partialResult * 10 + i;
                        var doubleResult = result * 2;
                        if (doubleResult.ToString().Length == result.ToString().Length)
                        {
                            Console.WriteLine($"Number of digits = {numOfDigits + 1}");
                            Console.WriteLine($"Last digit = {i}");
                            Console.WriteLine($"Partial = {partialResult:F0}");
                            Console.WriteLine($"Result = {result:F0}");
                            Console.WriteLine($"Double = {doubleResult:F0}");
                            found = true;
                        }

                    }
                }

                numOfDigits++;
            }
        }


    }
}
