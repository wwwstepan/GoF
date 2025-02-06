
using static My.CommonTools;
using System.Text;

namespace GoF;

public class UseBuilder
{
    public UseBuilder()
    {
        var b = new MyStrBuilder();
        b.Add("qwe");
        b.Add(" asdfghj ");
        b.Add("======zxc======");
        print(b);
    }
}

public class MyStrBuilder
{
    private int _cap = 10;
    private int _size = 0;
    private byte[] _buf;

    public MyStrBuilder()
    {
        _buf = new byte[_cap];
    }

    public void Add(string s)
    {
        var bytes = Encoding.UTF8.GetBytes(s);
        var len_bytes = bytes.Length;

        var new_cap = _cap;
        while (_size + len_bytes > new_cap)
            new_cap *= 2;
        
        if (new_cap > _cap)
        {
            var new_buf = new byte[new_cap];
            _buf.CopyTo(new_buf, 0);
            _buf = new_buf;
            _cap = new_cap;
        }

        bytes.CopyTo(_buf, _size);
        _size += len_bytes;
    }

    public override string ToString() => Encoding.UTF8.GetString(_buf, 0 , _size);
}
