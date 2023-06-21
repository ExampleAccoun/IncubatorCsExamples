using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample7_Lambda : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        // Example action 1 parameter
        Action<string> printTwoTimes = (s) => Console.WriteLine(s + " " + s);

        printTwoTimes("Hello");
        
        PrintSeparator();
        
        // Example action 2 parameters
        Action<string, int> printManyTimes =
            (s, howMany) => Console.WriteLine(string.Concat(Enumerable.Repeat(s, howMany)));

        printManyTimes("Hello ", 4);
        
        PrintSeparator();
        
        // Example Func 1 parameter
        Func<int, int> square = (num) => num * num;
        
        Console.WriteLine(square(4));
        
        PrintSeparator();
        
        // Example Func 2 parameters
        Func<int, int, string> textConnectedNumbers = (num1, num2) => $"{num1}{num2}";
        
        Console.WriteLine(textConnectedNumbers(13, 37));
    }
}