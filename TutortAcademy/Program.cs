using TutortAcademy.WeekOneIntroductionToProgramming;
using WeekOneIntroduction.TestData;

AssignmentOne assignmentOne = new AssignmentOne();
TestDataForAssingments testDataForAssingments = new TestDataForAssingments();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion One is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionOne_findMaxOfThreeElements(testDataForAssingments.questionOneTempData);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion One is finished\n");


Console.WriteLine("\nQuestion Two is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionTwo_findMinOfThreeElements(testDataForAssingments.questionTwoTempData);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Two is finished\n");


Console.WriteLine("\nQuestion Three is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionThree_findTheMidElementsOfThreeElements(testDataForAssingments.questionThreeTempData);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Three is finished\n");


Console.WriteLine("\nQuestion Four is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionFour_nTimesNumberTriangleWriter(testDataForAssingments.questionFourInput);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Four is finished\n");

Console.WriteLine("\nQuestion Five is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionFive_nTimesNumberTriangleWriterReverse(testDataForAssingments.questionFiveInput);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Five is finished\n");


Console.WriteLine("\nQuestion Six is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionSix_findOddElements(testDataForAssingments.questionSixTempData);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Six is finished\n");


Console.WriteLine("\nQuestion Six solution two is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionSix_findOddElementsSolTwo(testDataForAssingments.questionSixTempData);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Six solution two is finished\n");



Console.WriteLine("\nQuestion Seven is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionSeven_sumOfTheGivenArray(testDataForAssingments.questionSevenTempData);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Seven is finished\n");


Console.WriteLine("\nQuestion Eight evenCase is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionEight_findFirstEvenNumber(testDataForAssingments.questionEightTempDataForFirstEvenNumber);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Seven evenCase is finished\n");


Console.WriteLine("\nQuestion Eight -1 case is started\n");
Console.ForegroundColor = ConsoleColor.Red;
assignmentOne.QuestionEight_findFirstEvenNumber(testDataForAssingments.questionEightTempDataForMınusOne);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nQuestion Seven -1 case is finished\n");


