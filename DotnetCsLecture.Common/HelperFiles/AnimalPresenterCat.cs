namespace DotnetCsLecture.Common.HelperFiles;

public class AnimalPresenterCat
{
    private Animal _animal = new Cat(1.5f);

    public void PresentNoise()
    {
        _animal.MakeNoise();
    }
}