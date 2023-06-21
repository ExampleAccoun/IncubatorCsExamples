namespace DotnetCsLecture.Common.HelperFiles;

public class Animal
{
    private float _walkingDistance;
    
    public Animal(float walkingDistance)
    {
        _walkingDistance = walkingDistance;
    }

    public void Walk()
    {
        Console.WriteLine($"*walking {_walkingDistance:F2} meters");
    }

    public void Walk(int howManySteps)
    {
        float fullDistance = _walkingDistance * howManySteps;
        
        Console.WriteLine($"Walking {fullDistance:F2} meters");
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine("*Makes animal noises*");
    }
}