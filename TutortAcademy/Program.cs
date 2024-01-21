// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;
using System.Text;
using TutortAcademy.WeekOneIntroductionToProgramming;


LectureOne lectureOne = new LectureOne();
LectureTwo lectureTwo = new LectureTwo();
AssignmentOne lectureOneAssignment = new AssignmentOne();

/*

int?[] arr = { 4, 1, 5, 6, 7, 8, 10, 2, -10, -11, 8, null, null, null, null, null };

lectureOne.isElementPresent(arr,10,8);
lectureOne.isElementPresentSecond(arr,10,8);

Console.WriteLine("LectureOneIsFınıshed");
Console.WriteLine("LectureOneIsFınıshed");




*/
//lectureTwo.pascalTriangeTufanSolution();

//lectureTwo.printPatternOne();


int[] arg = { 1, 2, 3};
//lectureOneAssignment.findMaxOfThreeElements(arg);
//lectureOneAssignment.findMinOfThreeElements(arg);


//lectureOneAssignment.findTheMidElementsOfThreeElements(arg);

char[] arr = { 'a', 'b', 'c','d','e','f','g','h'};

// part 1 'd','e','f','g','h' => h g f e d
// part 2 a b c => reverse c b a

// expectedresult c b a h g f e d => d e f g h a b c

//lectureFour
/*void rotateFrom(char[] arr, int from)
{
    reverse(arr, from, arr.Length - 1);
    reverse(arr, 0, from - 1);
    reverse(arr, 0, arr.Length - 1);
}


##*/

//problem 3
//Run length encoding "abbbcddddeeefaaaa" => ab3cd5e3fa4


//Solve Yourself


//problem 4
//Run length type 4.
//"abbbcddddeeefaaaa" => "a1b3c1d5e3f1a4" output will never be longer then input


// "abcd" => "a1b1c1d1" wrong input
// "aaabcd" => a3b1c1d1 invalid input

//  Solve this problem without additional space or solve i inplace.














//benefit of compression: a => a1 => -1
// aaaaa => a5 => 3

// [a,b,c,d,e,e,e,e,e,e]
// [a,b,c,d,e,7,null,null,null,null,null]

// [null,null,null,null,null,a,b,c,d,e,7]

//[a,1, b1, c,1, d,1, e,7] ;

// step-1
// 

///### Next followup question 
///"aabbbbbb3334555555" => "a2b6321375"

// Change this value to adjust the number of rows

// Loop through each row
//lectureOneAssignment.nTimesNumberTriangleWriter(10);

int[] array = { 1, 5, 6, 4, 3, 2, 8 };

int[] sumArray = { 1, 2, 6, 3, 5 };

int[] oddArray = { 1, 3, 5, 7 }; 

//lectureOneAssignment.findOddElements(array);
//lectureOneAssignment.sumOfTheGivenArray(sumArray);


lectureOneAssignment.findFirstEvenNumber(oddArray);