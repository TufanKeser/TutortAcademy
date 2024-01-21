using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutortAcademy.WeekOneIntroductionToProgramming
{
    public class LectureTwo
    {
        public void printOneToTen()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void printPascalTriangle(int level)
        {
            if (level == 1)
            {
                Console.WriteLine(1);
            }
            if(level == 2)
            {
                Console.WriteLine(1);
                Console.WriteLine(2);
            }

            int[] prevValues = new int[level];
            int[] newValues = new int[level];

            prevValues[0] = 1;
            newValues[1] = 1;

            for(int i = 3; i <= level; i++)
            {
                newValues[0] = 1;
                for(int k =1; k < level-1; k++)
                {
                    newValues[k] = prevValues[k - 1] + prevValues[k];
                }
                for(int j = 0; j < level; i++)
                {
                    prevValues[j] = newValues[j];
                }

            }

            for(int i = 0; i <level; i++){
                Console.WriteLine(newValues[i]);
            }

        }

        public void pascalTriangeTufanSolution()
        {
            Console.Write("Enter the number of rows for Pascal's Triangle: ");
            int numRows = Convert.ToInt32(Console.ReadLine());

            int[][] pascalsTriangle = GeneratePascalsTriangle(numRows);

            foreach (var row in pascalsTriangle)
            {
                foreach(var pair in row)
                {
                    Console.Write(pair + " ");
                }
                Console.WriteLine();

            }
        }

        int[][] GeneratePascalsTriangle(int numRows)
        {
            int[][] triangle = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                triangle[i] = new int[i + 1];
                int currentValue = 1;

                for (int j = 0; j <= i; j++)
                {
                    triangle[i][j] = currentValue;
                    currentValue = currentValue * (i - j) / (j + 1);
                }
            }

            return triangle;
        }


        public void printPatternOne()
        {
            Console.WriteLine("Enter the value of N:");
            int N = int.Parse(Console.ReadLine());

            PrintPattern1(N);
        }

       static void PrintPattern1(int N)
        {
            for (int diff = 0; diff < N; diff++)
            {
                for (int i = 0; i + diff < N; i++)
                {
                    int j = i + diff;
                    Console.Write($"({i},{j}) ");
                }
                Console.WriteLine();
            }
        }


      
    }
}
