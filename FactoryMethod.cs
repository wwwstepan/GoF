using static My.CommonTools;
namespace GoF;

public class UseFactoryMethod
{
    public UseFactoryMethod()
    {
        var creators = new List<FactoryMethod>
        {
            new M1(),
            new M2(),
            new M1()
        };

        foreach (var creator in creators)
            print(creator.Create());
    }
}

public abstract class FactoryMethod
{
    public abstract AbstractA Create();
}

public class M1 : FactoryMethod
{
    public override AbstractA Create() => new A1();
}

public class M2 : FactoryMethod
{
    public override AbstractA Create() => new A2();
}
