namespace DotnetCsLecture.Common.HelperFiles;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int StartYear { get; set; }
    public int CurrentGrade { get; set; }
    public List<ClassGrade> ClassGrades { get; set; }

    public override string ToString()
    {
        string classGrades = ClassGrades.Count > 0 ? string.Join(", ", ClassGrades) : "None";
        string studentString =
            $"{Name}: Age {Age}| StartYear {StartYear}| CurrentGrade {CurrentGrade}| ClassGrades: {classGrades}";
        return studentString;
    }
}