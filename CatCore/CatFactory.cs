namespace CatCore;
public interface ICatFactory {
    Cat CreateCat();
}

internal sealed class CatFactory : ICatFactory {
    private readonly ICatCreator catCreator;

    public CatFactory(ICatCreator catCreator) {
        this.catCreator = catCreator;
    }
    public Cat CreateCat() {
        return catCreator.CreateCat();
    }
}