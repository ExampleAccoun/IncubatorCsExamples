using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample1_BasicTypes : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        float a_f = 0.2f, b_f = 0.1f;
        double a_dbl = 0.2, b_dbl = 0.1;
        decimal a_dec = 0.2m, b_dec = 0.1m;

        float sum_f = a_f + b_f;
        double sum_dbl = a_dbl + b_dbl;
        decimal sum_dec = a_dec + b_dec;
        
        Console.WriteLine($"Float: {sum_f}");
        Console.WriteLine($"Double: {sum_dbl}");
        Console.WriteLine($"Decimal: {sum_dec}");
        
        PrintSeparator();
        
        Console.WriteLine($"Float: { 1f / 3 }");
        Console.WriteLine($"Double: { 1.0 / 3 }");
        Console.WriteLine($"Decimal: { 1m / 3 }");
    }
}