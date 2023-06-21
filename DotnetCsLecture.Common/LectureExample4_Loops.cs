using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample4_Loops : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        // While loop

        Random random = new Random(2023);
        int a = 0;
        
        while (a < 85)
        {
            a = random.Next(100);
            Console.WriteLine(a);
        }
        
        PrintSeparator();
        
        // Do .. while loop

        random = new Random(2106);
        a = 100;

        do
        {
            a = random.Next(100);
            Console.WriteLine(a);
        } while (a < 80);
        
        PrintSeparator();
        
        // For loop

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        
        PrintSeparator();
        
        // Foreach loop

        int[] arr = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

        foreach (int number in arr)
        {
            Console.WriteLine(number);
        }
    }
}