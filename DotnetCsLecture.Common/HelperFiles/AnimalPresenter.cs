namespace DotnetCsLecture.Common.HelperFiles;

public class AnimalPresenter
{
    private Animal _animal = new Animal(1.5f);

    public void PresentNoise()
    {
        _animal.MakeNoise();
    }
}