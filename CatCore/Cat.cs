namespace CatCore;

public class Cat {
    public bool HasTail { get; set; }
    public string? Name { get; set; }

    public override string ToString() {
        if(HasTail) {
            return $"{GetName()} with a tail :)";
        } else {
            return $"{GetName()} without a tail :(";
        }
    }
    private string GetName() {
        return string.IsNullOrEmpty(Name) ? "A street cat" : Name;
    }
}

