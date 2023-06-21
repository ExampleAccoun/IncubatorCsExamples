namespace DotnetCsLecture.Common.HelperFiles;

public class AnimalPresenterDog
{
    private Animal _animal = new Dog(1.5f);

    public void PresentNoise()
    {
        _animal.MakeNoise();
    }
}