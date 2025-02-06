using static My.CommonTools;

namespace GoF;

public class UseBridge
{
    public UseBridge()
    {
        var cat = new CatBridge(new Tiger());
        cat.Go();
        cat.Say();

        var cat2 = new AdvancedCatBridge(new Pantera());
        cat2.GoAndSay();
    }
}

public class CatBridge
{
    protected readonly ICat _cat;

    public CatBridge(ICat cat)
    {
        _cat = cat;
    }
    public void Go() => _cat.Go();
    public void Say() => _cat.Say();
}

// Расширяем функциональность, не трогая Tiger и Pantera
public class AdvancedCatBridge : CatBridge
{
    public AdvancedCatBridge(ICat cat) : base(cat) { }

    public void GoAndSay()
    {
        _cat.Go();
        _cat.Say();
    }
}

public interface ICat
{
    int Steps { get; set; }
    void Say();
    void Go();
}

public class Tiger : ICat
{
    public int Steps { get; set; } = 0;
    public void Go() => Steps += 3;
    public void Say() => print($"Tiger, {Steps} steps");
}

public class Pantera : ICat
{
    public int Steps { get; set; } = 0;
    public void Go() => Steps += 5;
    public void Say() => print($"Pantera, {Steps} steps");
}
