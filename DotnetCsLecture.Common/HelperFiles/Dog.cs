namespace DotnetCsLecture.Common.HelperFiles;

public class Dog : Animal
{
    public Dog(float walkingDistance) : base(walkingDistance)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("*Woof woof!*");
    }
}