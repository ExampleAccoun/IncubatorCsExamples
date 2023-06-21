namespace DotnetCsLecture.Common.HelperFiles;

public class ClassGrade
{
    public string ClassName { get; set; }
    public int Grade { get; set; }

    public override string ToString()
    {
        return $"{ClassName} - {Grade}";
    }
}