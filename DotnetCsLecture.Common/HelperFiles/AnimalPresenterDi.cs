namespace DotnetCsLecture.Common.HelperFiles;

public class AnimalPresenterDi
{
    private Animal _animal;

    public AnimalPresenterDi(Animal animal)
    {
        _animal = animal;
    }

    public void PresentNoise()
    {
        _animal.MakeNoise();
    }
}