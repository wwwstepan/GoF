using static My.CommonTools;

namespace GoF;

public class UseComposite
{
    public UseComposite()
    {
        var ord = new Order("John");

        ord.Add(new Item(20));

        var box1 = new Box();
        box1.Add(new Item(10));
        box1.Add(new Item(12));
        ord.Add(box1);

        var box2 = new Box();
        box2.Add(new Item(5));
        box2.Add(new Item(6));
        box2.Add(new Item(7));

        var box3 = new Box();
        box3.Add(new Item(30));
        box3.Add(new Item(15));
        box3.Add(box2);
        ord.Add(box3);

        print($"Total order price: {ord.Price()}");
    }
}

public class Order(string customerName) : Box
{
    private readonly string _customerName = customerName;
}

public class Item()
{
    private decimal _price;

    public Item(decimal price) : this() => _price = price;

    public virtual decimal Price() => _price;
}

public class Box() : Item()
{
    private readonly List<Item> _items = new();

    public void Add(Item item) => _items.Add(item);

    public override decimal Price() => _items.Sum(x => x.Price());
}
