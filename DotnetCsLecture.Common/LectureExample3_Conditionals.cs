using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample3_Conditionals : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        // Value types
        int a = 10;
        int b = 10;

        if (a == b)
        {
            Console.WriteLine("The integers are equal!");
        }
        else
        {
            Console.WriteLine("The integers are NOT equal!");
        }
        
        PrintSeparator();
        
        // Reference types
        int[] arr1 = new[] { 1, 2, 3 };
        int[] arr2 = new[] { 1, 2, 3 };

        if (arr1 == arr2)
        {
            Console.WriteLine("The arrays are equal!");
        }
        else
        {
            Console.WriteLine("The arrays are NOT equal");
        }
        
        PrintSeparator();
        
        // Exception? - string
        string str1 = "Hello";
        string str2 = "Hello";

        if (str1 == str2)
        {
            Console.WriteLine("The strings are equal!");
        }
        else
        {
            Console.WriteLine("The strings are NOT equal!");
        }
        
        PrintSeparator();

        // Is operator
        object obj = 1;

        if (obj is int)
        {
            Console.WriteLine("Object is int!");
        }
        else
        {
            Console.WriteLine("Object is NOT int");
        }
        
        PrintSeparator();
        
        // Is operator - null checks

        int[] arrNull = GetNullArray();

        if (arrNull is null)
        {
            Console.WriteLine("Is null works");
        }
        if (arrNull == null)
        {
            Console.WriteLine("== null works");
        }

        if (arr1 is not null)
        {
            Console.WriteLine("Is not null works!");
        }
    }

    private int[] GetNullArray()
    {
        return null;
    }
}