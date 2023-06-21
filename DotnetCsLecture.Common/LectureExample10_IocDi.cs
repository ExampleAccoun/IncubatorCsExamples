using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample10_IocDi : ExampleBase, ILectureExample
{
    public void ShowExample()
    {
        // Class using different class
        AnimalPresenter animalPresenter = new AnimalPresenter();
        
        animalPresenter.PresentNoise();
        
        // What if we wanted to change?
        
        PrintSeparator();

        AnimalPresenterDog animalPresenterDog = new AnimalPresenterDog();
        animalPresenterDog.PresentNoise();

        AnimalPresenterCat animalPresenterCat = new AnimalPresenterCat();
        animalPresenterCat.PresentNoise();
        
        PrintSeparator();
        
        // Using DI
        AnimalPresenterDi animalPresenterDiDog = new AnimalPresenterDi(new Dog(1.5f));
        AnimalPresenterDi animalPresenterDiCat = new AnimalPresenterDi(new Cat(1.5f));
        
        animalPresenterDiDog.PresentNoise();
        animalPresenterDiCat.PresentNoise();
    }
}