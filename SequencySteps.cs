using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulArrays
{
    class SequencySteps
    {
        //Console.WriteLine("enter number of test cases");
        private int testCases; 
        private int seqSize;
        private List<int> testSeq;
        private int[] res = new int[4];
        private int sum;
        private int counta;
        //private int[] triangle;

        public void CheckSequency()
        {
            testCases = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < testCases; t++)
            {
                //Console.WriteLine("enter the sequence size");
                seqSize = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("enter the sequence");

                testSeq = Console.ReadLine()
                    .Split(' ')
                    .Select(x => Convert.ToInt32(x))
                    .ToList();

                sum = testSeq.Sum();

                for (int i = 1; i < 4; i++)
                {
                    res[i] = testSeq.FindAll(x => x % 4 == i).Count();
                }

                counta = 0;

                if (sum % 4 != 0)
                {
                    Console.WriteLine(-1);
                    break;
                }

                if (res[1] > res[3])
                {
                    res[1] = res[1] - res[3];
                    counta += res[3];
                    res[3] = 0;
                }
                else
                {
                    res[3] = res[3] - res[1];
                    counta += res[1];
                    res[1] = 0;
                }

                counta += res[2] / 2;
                res[2] = res[2] % 2;
                res[2] += res[1] / 2;
                res[2] += res[3] / 2;
                counta += res[1] / 2;
                counta += res[3] / 2;

                Console.WriteLine(counta);
            }
        }
    }
}
