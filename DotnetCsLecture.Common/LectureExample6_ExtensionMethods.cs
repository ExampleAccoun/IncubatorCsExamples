using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common.LectureExample6_ExtensionMethods;

public class LectureExample6_ExtensionMethods : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        int a = 12;

        int b = a.GetSquare();
        
        Console.WriteLine($"a: {a}\tb: {b}");
        
        PrintSeparator();

        string sentence = "This is an example sentence";
        string textToAppend = "Text to append";

        string changedSentence = sentence.GetFirstWordFromSentenceAndAddText(textToAppend);
        
        Console.WriteLine(changedSentence);
    }
}