using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutortAcademy.WeekOneIntroductionToProgramming
{
    public class AssignmentOne
    {

        public void findMaxOfThreeElements(int[] arr)
        {
            int maxValue = 0;
            for(int i = 0; i <arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            Console.WriteLine("MaxValue is " + maxValue);
            Console.ReadLine();
        }


        public void findMinOfThreeElements(int[] arr)
        {
            
            int minValue = 0;
            
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            Console.WriteLine("Min value is " + minValue);
            Console.ReadLine();
        }

        public void findTheMidElementsOfThreeElements(int[] arr)
        {

            int iterator = (arr.Length + 1) / 2;

            int? expectedValue = 0;

            for(int i = 0; i < iterator; i++)
            {
                expectedValue = arr[i];
            }

            Console.WriteLine("Middle Value is " + expectedValue);

        }

        public void nTimesNumberTriangleWriter(int n)
        {
            for(int i = 1; i <=n; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public void nTimesNumberTriangleWriterReverse(int n)
        {
            for(int i = 0; i<=n; i++)
            {
                for(int j = 1; j+i <=n; j++)
                {
                    Console.Write(j + " ");
                }

            Console.WriteLine();
            }
        }

        public void findOddElements(int[] arr)
        {
            int[] result = arr.Where(x => x % 2 != 0).ToArray();
            for(int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (result[i] != result.Last())
                {
                    Console.Write(",");
                }
            }
            
        }

        public void findOddElementsSolTwo(int[] arr)
        {
            List<int> result =  arr.ToList();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    result.Remove(i);
                }
                Console.Write(arr[i].ToString());
                if (arr[i] != arr.Last())
                {
                    Console.Write(",");
                }
            }

        }

        public void sumOfTheGivenArray(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of the given array is " + sum.ToString());
        }

        public void findFirstEvenNumber(int[] arr)
        {
            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("First even number of the list is " + arr[i].ToString());
                    break;
                }
                else
                {
                    oddCount++;
                }

                if(oddCount == arr.Length - 1)
                {
                    Console.WriteLine("-1");
                }
                
            }

           
        }



    }
}
