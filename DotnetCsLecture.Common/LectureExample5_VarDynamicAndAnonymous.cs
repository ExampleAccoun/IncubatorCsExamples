using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample5_VarDynamicAndAnonymous : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        // var and dynamic
        int a = 1;
        var b = 1;
        dynamic c = 1;

        // Gives error
        // a = 1.5;
        // b = 1.5;
        
        Console.WriteLine($"c: {c}");
        c = 1.5;
        Console.WriteLine($"c: {c}");
        // c.Join(", ", a);

        PrintSeparator();
        
        // Anonymous types

        var anonymous = new { Number1 = a, Number2 = b };
        
        Console.WriteLine(anonymous);
        Console.WriteLine(anonymous.Number1);
        Console.WriteLine(anonymous.Number2);
        
        PrintSeparator();

        var anonymous2 = new { a, b };
        Console.WriteLine(anonymous2);
        Console.WriteLine(anonymous2.a);
        Console.WriteLine(anonymous2.b);
    }
}