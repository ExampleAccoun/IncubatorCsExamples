namespace DotnetCsLecture.Common.HelperFiles;

public static class ExampleExtensions
{
    public static int GetSquare(this int number)
    {
        return number * number;
    }

    public static string GetFirstWordFromSentenceAndAddText(this string sentence, string addedText)
    {
        string firstWord = sentence.Split(' ')[0];

        return $"{firstWord} {addedText}";
    }
}