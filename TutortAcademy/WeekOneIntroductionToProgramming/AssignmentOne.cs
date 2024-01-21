using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutortAcademy.WeekOneIntroductionToProgramming
{
    public class AssignmentOne
    {

        public void QuestionOne_findMaxOfThreeElements(int[] arr)
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


        public void QuestionTwo_findMinOfThreeElements(int[] arr)
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

        public void QuestionThree_findTheMidElementsOfThreeElements(int[] arr)
        {

            int iterator = (arr.Length + 1) / 2;

            int? expectedValue = 0;

            for(int i = 0; i < iterator; i++)
            {
                expectedValue = arr[i];
            }

            Console.WriteLine("Middle Value is " + expectedValue);

        }

        public void QuestionFour_nTimesNumberTriangleWriter(int n)
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

        public void QuestionFive_nTimesNumberTriangleWriterReverse(int n)
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

        public void QuestionSix_findOddElements(int[] arr)
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

        public void QuestionSix_findOddElementsSolTwo(int[] arr)
        {
            List<int> list = arr.ToList();
            list.RemoveAll(x => x % 2 == 0);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);

                if (i < list.Count - 1)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine();

        }

        public void QuestionSeven_sumOfTheGivenArray(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of the given array is " + sum.ToString());
        }

        public void QuestionEight_findFirstEvenNumber(int[] arr)
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
