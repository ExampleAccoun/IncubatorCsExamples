using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample2_RefVsVal : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        // Value type
        int a = 7;
        int b = a;
        
        Console.WriteLine($"a: {a}, b: {b}");

        b = 3;
        
        Console.WriteLine($"a: {a}, b: {b}");
        
        PrintSeparator();
        
        // Reference type

        int[] arrA = { 1, 2, 3 };
        int[] arrB = arrA;
        
        Console.WriteLine($"arrA: {GetPrintableArray(arrA)}, arrB: {GetPrintableArray(arrB)}");

        arrB[2] = 7;
        
        Console.WriteLine($"arrA: {GetPrintableArray(arrA)}, arrB: {GetPrintableArray(arrB)}");
    }

    private string GetPrintableArray(int[] arr)
    {
        return $"[{string.Join(", ", arr)}]";
    }
}