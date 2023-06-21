using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample9_OopPrinciples : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        var someAnimal = new Animal(2.5f);
        // var animalWalkDistance = someAnimal._walkingDistance; - gives error
        
        someAnimal.Walk();
        someAnimal.MakeNoise();
        someAnimal.Walk(3);
        
        PrintSeparator();

        var someDog = new Dog(1.5f);
        
        Console.WriteLine("Dog:");
        someDog.Walk();
        someDog.MakeNoise();
        someDog.Walk(5);
    }
}