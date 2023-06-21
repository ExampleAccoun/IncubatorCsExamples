namespace DotnetCsLecture.Common.HelperFiles;

public class Cat : Animal
{
    public Cat(float walkingDistance) : base(walkingDistance)
    {
    }
    
    public override void MakeNoise()
    {
        Console.WriteLine("*Meow meow!*");
    }
}