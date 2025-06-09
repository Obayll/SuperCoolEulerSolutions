namespace ProjectEuler
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5 we get 3, 5, 6, and 9. The sum of these multiples is 23.<br/>
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    static public class Problem1
    {
        /// <summary>
        /// Naive, brute-force solution due to the excessive computation power modern machines have.
        /// </summary>
        static private int SumMultiples(int multiple, int max = 1000)
        {
            int sum = 0;

            for (int i = multiple; i < max; i += multiple)
                sum += i;

            return sum;
        }

        /// <summary>
        /// Arithmetic solution using the sum of an arithmetic series.
        /// </summary>
        static private int SumMultiplesArith(int multiple, int max = 1000)
        {
            //tex:
            //Number of Terms: $$\left\lfloor\frac{{L - 1}}{n}\right\rfloor$$
            //Where $L$ is the limit and $n$ is the multiple.

            //tex:
            //Sum of Multiples:$$n * \frac{{k * (k + 1)}}{2}$$
            //Where $k$ is the number of terms and $n$ is the multiple.

            int numTerms = (max - 1) / multiple;

            return multiple * (numTerms * (numTerms + 1) / 2);
        }

        static public void Run()
        {
            Console.WriteLine($"Problem1 (Naive): {SumMultiples(3) + SumMultiples(5) - SumMultiples(15)}");

            Console.WriteLine($"Problem1 (Arithmetic): {SumMultiplesArith(3) + SumMultiplesArith(5) - SumMultiplesArith(15)}");
        }
    }
}
