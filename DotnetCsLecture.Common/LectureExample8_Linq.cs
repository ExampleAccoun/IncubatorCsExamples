using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample8_Linq : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        List<Student> students = GenerateStudents();
        
        // All() - check if all students are 18 or more
        bool areAllStudentsAdults = students.All(x => x.Age >= 18);
        Console.WriteLine("Are all students 18 or more?: " + areAllStudentsAdults);
        
        PrintSeparator();
        
        // Any() - check if any student is 30 years old
        bool isAnyStudentThirty = students.Any(x => x.Age == 30);
        Console.WriteLine("Is any student 30 years old?: " + isAnyStudentThirty);

        PrintSeparator();
        
        // Count() - check how many students are there, and how many of them don't have any grades
        int numberOfStudents = students.Count();
        int numberOfStudentsWithoutGrades = students.Count(x => !x.ClassGrades.Any());
        
        Console.WriteLine($"Students: {numberOfStudents} | Without grades: {numberOfStudentsWithoutGrades}");
        
        PrintSeparator();
        
        // First() - find first student whose name starts with 'A', and first who is 40 years old
        Student studentWithNameStartingWithA = students.First(x => x.Name.StartsWith('A'));
        
        // Student firstStudentWhoIsForty = students.First(x => x.Age == 40);
        Student studentWhoIsForty = students.FirstOrDefault(x => x.Age == 40);
        
        Console.WriteLine($"First student starting with A: {studentWithNameStartingWithA} | First student who is 40: {studentWhoIsForty}");
        
        PrintSeparator();
        
        // Where() - find students who have are in 2nd grade and have any '1' grade
        // var studentsFound = students
        //     .Where(x => x.CurrentGrade == 2 && x.ClassGrades.Any(grade => grade.Grade == 1))
        //     .ToList();

        var studentsFound = students
            .Where(x => x.CurrentGrade == 2)
            .Where(x => x.ClassGrades.Any(grade => grade.Grade == 1))
            .ToList();

        PrintStudents(studentsFound);
        
        PrintSeparator();

        // Contains()
        var studentElijahWu = students.First(x => x.Name == "Elijah Wu");
        var studentAnthonyMccarthy = students.First(x => x.Name == "Anthony Mccarthy");

        bool isElijahWoInFilteredStudents = studentsFound.Contains(studentElijahWu);
        bool isAnthonyMccarthyInFilteredStudents = studentsFound.Contains(studentAnthonyMccarthy);

        Console.WriteLine($"Is Elijah Wu in students above? : {isElijahWoInFilteredStudents}");
        Console.WriteLine($"Is Anthony Mccarthy in students above? : {isAnthonyMccarthyInFilteredStudents}");
        
        PrintSeparator();

        // OrderBy() - order filtered students by age

        var sortedFilteredStudents = studentsFound
            .OrderBy(x => x.Age)
            .ToList();
        
        PrintStudents(sortedFilteredStudents);
        
        PrintSeparator();

        // Select() - Get ages of students

        var filteredStudentAges = sortedFilteredStudents
            .Select(x => x.Age)
            .ToArray();

        var averageAge = filteredStudentAges.Average();
        
        Console.WriteLine("Average filtered student age: " + averageAge);
    }

    private void PrintStudents(IEnumerable<Student> students)
    {
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }

    #region GeneratingStudents

    private List<Student> GenerateStudents()
    {
        var students = new List<Student>()
        {
            new Student
            {
                Name = "Santana David Kirch", Age = 22, StartYear = 2023, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Math", Grade = 3 },
                    new ClassGrade { ClassName = "Science", Grade = 2 }, new ClassGrade { ClassName = "IT", Grade = 3 },
                    new ClassGrade { ClassName = "Physics", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Elisa Hoover", Age = 29, StartYear = 2022, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Physics", Grade = 5 }, new ClassGrade { ClassName = "IT", Grade = 1 },
                    new ClassGrade { ClassName = "Math", Grade = 3 }, new ClassGrade { ClassName = "Music", Grade = 5 }
                }
            },
            new Student
            {
                Name = "Cairistìona Guto Schroder", Age = 23, StartYear = 2023, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 6 },
                    new ClassGrade { ClassName = "History", Grade = 1 },
                    new ClassGrade { ClassName = "Science", Grade = 5 },
                    new ClassGrade { ClassName = "English", Grade = 5 },
                    new ClassGrade { ClassName = "Math", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Tori Austin", Age = 20, StartYear = 2023, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "IT", Grade = 4 }, new ClassGrade { ClassName = "History", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Zaina Gilmore", Age = 28, StartYear = 2023, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Math", Grade = 2 },
                    new ClassGrade { ClassName = "History", Grade = 3 }, new ClassGrade { ClassName = "IT", Grade = 4 },
                    new ClassGrade { ClassName = "Music", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Sebastian Leonor Apeldoorn", Age = 21, StartYear = 2023, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "English", Grade = 4 } }
            },
            new Student
            {
                Name = "Crystal Burke", Age = 22, StartYear = 2020, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "English", Grade = 3 },
                    new ClassGrade { ClassName = "Biology", Grade = 3 },
                    new ClassGrade { ClassName = "Physics", Grade = 6 }, new ClassGrade { ClassName = "IT", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Sudarshan Chandana Jones", Age = 21, StartYear = 2022, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Physics", Grade = 3 },
                    new ClassGrade { ClassName = "Music", Grade = 3 },
                    new ClassGrade { ClassName = "History", Grade = 6 }, new ClassGrade { ClassName = "IT", Grade = 5 },
                    new ClassGrade { ClassName = "English", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Okropir Fiorenza Peusen", Age = 27, StartYear = 2021, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "History", Grade = 2 },
                    new ClassGrade { ClassName = "Music", Grade = 5 }, new ClassGrade { ClassName = "IT", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Edmund Strong", Age = 19, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "Physics", Grade = 2 } }
            },
            new Student
            {
                Name = "Anthony Mccarthy", Age = 22, StartYear = 2020, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Umair Bond", Age = 23, StartYear = 2022, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 1 },
                    new ClassGrade { ClassName = "Math", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Arjan Ibarra", Age = 26, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "English", Grade = 6 }, new ClassGrade { ClassName = "IT", Grade = 5 },
                    new ClassGrade { ClassName = "Physics", Grade = 6 },
                    new ClassGrade { ClassName = "Science", Grade = 6 },
                    new ClassGrade { ClassName = "Biology", Grade = 1 },
                    new ClassGrade { ClassName = "History", Grade = 6 },
                    new ClassGrade { ClassName = "Math", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Elijah Wu", Age = 26, StartYear = 2020, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 2 }, new ClassGrade { ClassName = "Math", Grade = 3 },
                    new ClassGrade { ClassName = "Physics", Grade = 2 }, new ClassGrade { ClassName = "IT", Grade = 1 },
                    new ClassGrade { ClassName = "History", Grade = 5 }
                }
            },
            new Student
            {
                Name = "Farrokh Amvrosiy Cipriani", Age = 24, StartYear = 2019, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Teresa Bloggs", Age = 27, StartYear = 2019, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "History", Grade = 4 },
                    new ClassGrade { ClassName = "Music", Grade = 2 },
                    new ClassGrade { ClassName = "Science", Grade = 2 },
                    new ClassGrade { ClassName = "English", Grade = 3 },
                    new ClassGrade { ClassName = "Math", Grade = 3 }, new ClassGrade { ClassName = "IT", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Amna Ferguson", Age = 23, StartYear = 2022, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Math", Grade = 2 },
                    new ClassGrade { ClassName = "English", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Gino Rahman Wyrzyk", Age = 29, StartYear = 2019, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Phyllis Vincent", Age = 24, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Ghada Pastor Giese", Age = 23, StartYear = 2023, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 5 },
                    new ClassGrade { ClassName = "Science", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Sofiya Sara Hyde", Age = 24, StartYear = 2018, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Math", Grade = 2 }, new ClassGrade { ClassName = "Music", Grade = 3 },
                    new ClassGrade { ClassName = "History", Grade = 4 },
                    new ClassGrade { ClassName = "Biology", Grade = 2 },
                    new ClassGrade { ClassName = "Physics", Grade = 2 }, new ClassGrade { ClassName = "IT", Grade = 4 },
                    new ClassGrade { ClassName = "English", Grade = 1 },
                    new ClassGrade { ClassName = "Science", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Bertie Hampton", Age = 18, StartYear = 2021, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "IT", Grade = 1 }, new ClassGrade { ClassName = "History", Grade = 5 },
                    new ClassGrade { ClassName = "Science", Grade = 5 }
                }
            },
            new Student
            {
                Name = "Jada Terrell", Age = 21, StartYear = 2018, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Hildiwara Bjarte Bancroft", Age = 30, StartYear = 2021, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Physics", Grade = 6 },
                    new ClassGrade { ClassName = "English", Grade = 5 },
                    new ClassGrade { ClassName = "Music", Grade = 3 },
                    new ClassGrade { ClassName = "History", Grade = 5 }
                }
            },
            new Student
            {
                Name = "Heather Miranda", Age = 23, StartYear = 2019, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 2 },
                    new ClassGrade { ClassName = "Science", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Varinia Ziva Acquarone", Age = 20, StartYear = 2022, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "Biology", Grade = 1 } }
            },
            new Student
            {
                Name = "Andy Walter", Age = 21, StartYear = 2022, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Claude Holland", Age = 29, StartYear = 2019, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 6 },
                    new ClassGrade { ClassName = "History", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Maximillian Burnett", Age = 30, StartYear = 2020, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Theodore Woods", Age = 29, StartYear = 2019, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Constance Bowen", Age = 18, StartYear = 2023, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Physics", Grade = 2 },
                    new ClassGrade { ClassName = "English", Grade = 2 },
                    new ClassGrade { ClassName = "Biology", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Fabio Mckinney", Age = 23, StartYear = 2022, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Rufus Hancock", Age = 30, StartYear = 2019, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 6 },
                    new ClassGrade { ClassName = "Biology", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Ricky Reid", Age = 28, StartYear = 2018, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Nathanael Hayes", Age = 18, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "Math", Grade = 4 } }
            },
            new Student
            {
                Name = "Oliver Douglas", Age = 27, StartYear = 2021, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Durans Trai Wyrick", Age = 18, StartYear = 2021, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Zachery Velasquez", Age = 22, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 1 },
                    new ClassGrade { ClassName = "Biology", Grade = 4 },
                    new ClassGrade { ClassName = "History", Grade = 4 },
                    new ClassGrade { ClassName = "Math", Grade = 1 }, new ClassGrade { ClassName = "Music", Grade = 1 },
                    new ClassGrade { ClassName = "English", Grade = 3 }, new ClassGrade { ClassName = "IT", Grade = 5 },
                    new ClassGrade { ClassName = "Physics", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Lily-Mae Reed", Age = 25, StartYear = 2020, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Daniel Holder", Age = 20, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Madeleine Mathis", Age = 28, StartYear = 2018, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "Physics", Grade = 4 } }
            },
            new Student
            {
                Name = "Dayana Patricija Emmett", Age = 20, StartYear = 2022, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "History", Grade = 2 },
                    new ClassGrade { ClassName = "Music", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Ronald Knight", Age = 30, StartYear = 2019, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "Physics", Grade = 4 } }
            },
            new Student
            {
                Name = "Lorenzo Koch", Age = 18, StartYear = 2022, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 2 },
                    new ClassGrade { ClassName = "Physics", Grade = 1 },
                    new ClassGrade { ClassName = "History", Grade = 2 },
                    new ClassGrade { ClassName = "Science", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Anton French", Age = 24, StartYear = 2018, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "IT", Grade = 6 }, new ClassGrade { ClassName = "History", Grade = 3 },
                    new ClassGrade { ClassName = "Math", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Eleri Prince", Age = 29, StartYear = 2023, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "IT", Grade = 1 } }
            },
            new Student
            {
                Name = "Alison Manning", Age = 27, StartYear = 2018, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Ildefonso Lishan Lynton", Age = 27, StartYear = 2022, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "IT", Grade = 4 }, new ClassGrade { ClassName = "Biology", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Finn Britt Quixano", Age = 21, StartYear = 2019, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Callan Rivera", Age = 21, StartYear = 2022, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Math", Grade = 6 }, new ClassGrade { ClassName = "Music", Grade = 1 },
                    new ClassGrade { ClassName = "Science", Grade = 4 },
                    new ClassGrade { ClassName = "History", Grade = 4 },
                    new ClassGrade { ClassName = "Biology", Grade = 3 },
                    new ClassGrade { ClassName = "English", Grade = 2 }, new ClassGrade { ClassName = "IT", Grade = 3 },
                    new ClassGrade { ClassName = "Physics", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Melissa Patel", Age = 21, StartYear = 2023, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Jaron Idun Roosa", Age = 24, StartYear = 2022, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "English", Grade = 3 } }
            },
            new Student
            {
                Name = "Tillie Andrews", Age = 24, StartYear = 2020, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Math", Grade = 2 }, new ClassGrade { ClassName = "Music", Grade = 5 },
                    new ClassGrade { ClassName = "History", Grade = 4 },
                    new ClassGrade { ClassName = "Physics", Grade = 3 },
                    new ClassGrade { ClassName = "Biology", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Frederic Nunez", Age = 27, StartYear = 2021, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "History", Grade = 4 },
                    new ClassGrade { ClassName = "Biology", Grade = 2 },
                    new ClassGrade { ClassName = "Physics", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Karen Greer", Age = 19, StartYear = 2018, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "IT", Grade = 1 }, new ClassGrade { ClassName = "English", Grade = 1 },
                    new ClassGrade { ClassName = "Music", Grade = 1 },
                    new ClassGrade { ClassName = "Physics", Grade = 2 },
                    new ClassGrade { ClassName = "Biology", Grade = 1 },
                    new ClassGrade { ClassName = "Math", Grade = 5 },
                    new ClassGrade { ClassName = "Science", Grade = 1 },
                    new ClassGrade { ClassName = "History", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Nicola Morrison", Age = 22, StartYear = 2023, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Math", Grade = 2 },
                    new ClassGrade { ClassName = "Physics", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Ratko Limbikani Berlusconi", Age = 24, StartYear = 2018, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 4 },
                    new ClassGrade { ClassName = "English", Grade = 5 }
                }
            },
            new Student
            {
                Name = "Juliette Pacheco", Age = 29, StartYear = 2021, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Shawn Allison", Age = 28, StartYear = 2021, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "English", Grade = 1 },
                    new ClassGrade { ClassName = "Science", Grade = 2 },
                    new ClassGrade { ClassName = "Math", Grade = 4 },
                    new ClassGrade { ClassName = "Physics", Grade = 1 },
                    new ClassGrade { ClassName = "Music", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Gracie Farrell", Age = 21, StartYear = 2022, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "IT", Grade = 5 } }
            },
            new Student
            {
                Name = "Dáirine Demetrio Albert", Age = 26, StartYear = 2021, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "English", Grade = 3 },
                    new ClassGrade { ClassName = "Music", Grade = 6 },
                    new ClassGrade { ClassName = "Biology", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Younes Amelina Tawfeek", Age = 25, StartYear = 2018, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 6 }, new ClassGrade { ClassName = "IT", Grade = 6 },
                    new ClassGrade { ClassName = "Math", Grade = 5 },
                    new ClassGrade { ClassName = "Biology", Grade = 6 },
                    new ClassGrade { ClassName = "Physics", Grade = 3 },
                    new ClassGrade { ClassName = "History", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Siobhan Rodriguez", Age = 30, StartYear = 2021, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "IT", Grade = 5 } }
            },
            new Student
            {
                Name = "Manawydan Crispian McCullough", Age = 20, StartYear = 2020, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Farrah Suarez", Age = 22, StartYear = 2020, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 4 },
                    new ClassGrade { ClassName = "Science", Grade = 6 },
                    new ClassGrade { ClassName = "English", Grade = 3 },
                    new ClassGrade { ClassName = "Math", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Dorothy Hahn", Age = 28, StartYear = 2023, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 2 },
                    new ClassGrade { ClassName = "Biology", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Atefeh Amira Pozzi", Age = 25, StartYear = 2023, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 6 }, new ClassGrade { ClassName = "IT", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Erminlinda Caris Kipling", Age = 25, StartYear = 2022, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 6 },
                    new ClassGrade { ClassName = "English", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Dawn Shields", Age = 28, StartYear = 2023, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Physics", Grade = 6 },
                    new ClassGrade { ClassName = "Science", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Osian Ho", Age = 19, StartYear = 2023, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "Science", Grade = 1 } }
            },
            new Student
            {
                Name = "Sonny Sandoval", Age = 23, StartYear = 2021, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Jahleel Oshrat Lau", Age = 21, StartYear = 2020, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Vardah Alex Nordskov", Age = 24, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "IT", Grade = 1 }, new ClassGrade { ClassName = "History", Grade = 5 },
                    new ClassGrade { ClassName = "Music", Grade = 3 },
                    new ClassGrade { ClassName = "Science", Grade = 2 },
                    new ClassGrade { ClassName = "Physics", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Robbie Stuart", Age = 24, StartYear = 2019, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "IT", Grade = 5 }, new ClassGrade { ClassName = "Math", Grade = 6 },
                    new ClassGrade { ClassName = "History", Grade = 3 },
                    new ClassGrade { ClassName = "English", Grade = 4 },
                    new ClassGrade { ClassName = "Biology", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Kira Marquez", Age = 19, StartYear = 2021, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "English", Grade = 6 },
                    new ClassGrade { ClassName = "Physics", Grade = 3 },
                    new ClassGrade { ClassName = "Music", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Tyrone Massey", Age = 20, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 1 },
                    new ClassGrade { ClassName = "Math", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Gerald Fleming", Age = 30, StartYear = 2018, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Meghan Lara", Age = 21, StartYear = 2021, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Simeon Short", Age = 27, StartYear = 2020, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 3 },
                    new ClassGrade { ClassName = "English", Grade = 1 }, new ClassGrade { ClassName = "IT", Grade = 6 },
                    new ClassGrade { ClassName = "Music", Grade = 6 },
                    new ClassGrade { ClassName = "Physics", Grade = 3 }
                }
            },
            new Student
            {
                Name = "Mariyah Rodgers", Age = 19, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 2 },
                    new ClassGrade { ClassName = "Physics", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Tashi Tugrul Kavanaugh", Age = 21, StartYear = 2023, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 5 },
                    new ClassGrade { ClassName = "Music", Grade = 4 }, new ClassGrade { ClassName = "Math", Grade = 3 },
                    new ClassGrade { ClassName = "Biology", Grade = 5 },
                    new ClassGrade { ClassName = "English", Grade = 5 },
                    new ClassGrade { ClassName = "Physics", Grade = 5 },
                    new ClassGrade { ClassName = "History", Grade = 6 }, new ClassGrade { ClassName = "IT", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Hermogenes Iacopo Shirazi", Age = 27, StartYear = 2022, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Alex Fernandez", Age = 28, StartYear = 2018, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 1 }, new ClassGrade { ClassName = "IT", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Harold Kim", Age = 24, StartYear = 2019, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 1 },
                    new ClassGrade { ClassName = "English", Grade = 1 },
                    new ClassGrade { ClassName = "History", Grade = 1 },
                    new ClassGrade { ClassName = "Biology", Grade = 6 }, new ClassGrade { ClassName = "IT", Grade = 6 },
                    new ClassGrade { ClassName = "Physics", Grade = 1 },
                    new ClassGrade { ClassName = "Math", Grade = 4 },
                    new ClassGrade { ClassName = "Science", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Talha Osborne", Age = 24, StartYear = 2021, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 6 },
                    new ClassGrade { ClassName = "Physics", Grade = 6 },
                    new ClassGrade { ClassName = "History", Grade = 2 },
                    new ClassGrade { ClassName = "Math", Grade = 4 },
                    new ClassGrade { ClassName = "English", Grade = 1 }, new ClassGrade { ClassName = "IT", Grade = 6 },
                    new ClassGrade { ClassName = "Biology", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Damon Stevenson", Age = 23, StartYear = 2019, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 5 }, new ClassGrade { ClassName = "IT", Grade = 2 },
                    new ClassGrade { ClassName = "Music", Grade = 5 },
                    new ClassGrade { ClassName = "Physics", Grade = 4 },
                    new ClassGrade { ClassName = "Biology", Grade = 2 },
                    new ClassGrade { ClassName = "English", Grade = 1 },
                    new ClassGrade { ClassName = "Math", Grade = 6 },
                    new ClassGrade { ClassName = "History", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Zamir Kisecawchuck Kayode", Age = 21, StartYear = 2019, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "English", Grade = 6 } }
            },
            new Student
            {
                Name = "Beatrice Villegas", Age = 27, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Blake Delacruz", Age = 30, StartYear = 2020, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "Physics", Grade = 5 } }
            },
            new Student
            {
                Name = "Henrietta Hilton", Age = 27, StartYear = 2022, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Music", Grade = 3 },
                    new ClassGrade { ClassName = "Physics", Grade = 4 },
                    new ClassGrade { ClassName = "History", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Leonardo Harrell", Age = 18, StartYear = 2019, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 4 },
                    new ClassGrade { ClassName = "English", Grade = 5 }
                }
            },
            new Student
            {
                Name = "Clarence Mccall", Age = 19, StartYear = 2019, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 1 },
                    new ClassGrade { ClassName = "Music", Grade = 1 }, new ClassGrade { ClassName = "Math", Grade = 1 },
                    new ClassGrade { ClassName = "Science", Grade = 2 },
                    new ClassGrade { ClassName = "Physics", Grade = 4 }, new ClassGrade { ClassName = "IT", Grade = 6 }
                }
            },
            new Student
            {
                Name = "Kristina Perez", Age = 29, StartYear = 2023, CurrentGrade = 2,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "History", Grade = 6 },
                    new ClassGrade { ClassName = "Music", Grade = 2 }, new ClassGrade { ClassName = "IT", Grade = 5 },
                    new ClassGrade { ClassName = "Math", Grade = 2 },
                    new ClassGrade { ClassName = "Physics", Grade = 4 }
                }
            },
            new Student
            {
                Name = "Jewel Aleksander Iwata", Age = 24, StartYear = 2018, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Biology", Grade = 4 },
                    new ClassGrade { ClassName = "Music", Grade = 2 }
                }
            },
            new Student
            {
                Name = "Raphael Crane", Age = 26, StartYear = 2021, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "Science", Grade = 5 },
                    new ClassGrade { ClassName = "English", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Dawud Gregory", Age = 27, StartYear = 2019, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "Biology", Grade = 6 } }
            },
            new Student
            {
                Name = "Yahya Villa", Age = 29, StartYear = 2022, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            },
            new Student
            {
                Name = "Oenone Hipolita Stigsson", Age = 27, StartYear = 2023, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>() { new ClassGrade { ClassName = "History", Grade = 3 } }
            },
            new Student
            {
                Name = "Vilhelm Caracalla Mohammed", Age = 26, StartYear = 2022, CurrentGrade = 3,
                ClassGrades = new List<ClassGrade>()
                {
                    new ClassGrade { ClassName = "English", Grade = 6 },
                    new ClassGrade { ClassName = "Music", Grade = 1 }
                }
            },
            new Student
            {
                Name = "Keisha Macdonald", Age = 20, StartYear = 2018, CurrentGrade = 1,
                ClassGrades = new List<ClassGrade>() { }
            }
        };

        return students;
    }

    #endregion GeneratingStudents
}