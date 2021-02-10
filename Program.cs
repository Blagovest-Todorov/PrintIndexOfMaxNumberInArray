using System;

namespace ArrayMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = {5,6,10,70,25,-1,0,10, -100, 100};
            int MaxNumber = arrNum[0]; //let assume that first number in the array is max/
            int indexMaxNum = 0;

            for (int i = 0; i < arrNum.Length; i++)
            {
                int currNumber = arrNum[i];

                for (int j = i+1; j < arrNum.Length; j++)
                {
                    if ((currNumber < arrNum[j]) && (arrNum[j] > MaxNumber))
                    {
                        MaxNumber = arrNum[j];
                        indexMaxNum = j;
                        break;
                    }
                }
            }

            Console.WriteLine($"{MaxNumber}");
            Console.WriteLine($"{indexMaxNum}");
        }
    }
}
