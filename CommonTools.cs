namespace My;

// for VS - no warning on names like "pr"
#pragma warning disable IDE1006

public static class CommonTools
{
    public static void print(object? s)
    {
        Console.WriteLine(s);
    }

    public static void print(string format, params object?[]? args)
    {
        Console.WriteLine(format, args);
    }
}
