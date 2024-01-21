using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutortAcademy.WeekOneIntroductionToProgramming
{
    public class LectureOne
    {
       public bool isElementPresent(int?[] arr, int N, int x)
        {
            for(int i = 0; ; i++)
            {
                if (arr[i] == null) break;
                if (arr[i] == x) return true;
            }
            return false;
        }

        public bool isElementPresentSecond(int?[] arr, int N, int x)
        {
            arr[N] = x;
            int i = 0;
            while (arr[i] != x)
            {
                i++;
            }
            if (i == N)
            {
                return false;
            }
            return true;

        }
    }
}
