using static My.CommonTools;

namespace GoF;

public class UseAbstractFactory
{
    public UseAbstractFactory()
    {
        new Client(new Fac1()).Create();
        new Client(new Fac2()).Create();
    }
}

public class Client(AbstractFactory fac)
{
    public void Create()
    {
        print(fac.CreateA());
        print(fac.CreateB());
    }
}

public abstract class AbstractFactory
{
    public abstract AbstractA CreateA();
    public abstract AbstractB CreateB();
}

public class Fac1 : AbstractFactory
{
    public override AbstractA CreateA() => new A1();
    public override AbstractB CreateB() => new B1();
}

public class Fac2 : AbstractFactory
{
    public override AbstractA CreateA() => new A2();
    public override AbstractB CreateB() => new B2();
}

