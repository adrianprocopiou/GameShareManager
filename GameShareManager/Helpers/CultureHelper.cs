using System;
using System.Linq;
using System.Threading;

public static class CultureHelper
{
    private static readonly string[] _cultures = {"en-US", "pt-BR"};

    public static string GetImplementedCulture(string name)
    {
        return _cultures.Any(c => c.Equals(name, StringComparison.InvariantCultureIgnoreCase)) ? name : GetDefaultCulture();
    }

    public static string GetDefaultCulture()
    {
        return _cultures[0];
    }
}