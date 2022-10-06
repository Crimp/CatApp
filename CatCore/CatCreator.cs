namespace CatCore;

internal interface ICatCreator {
    Cat CreateCat();
}
internal sealed class CatCreator : ICatCreator {
    public Cat CreateCat() {
        return new Cat();
    }
}
