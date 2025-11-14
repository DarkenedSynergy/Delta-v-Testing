using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Robust.Shared.Prototypes;

namespace Content.Shared._RMC14.Prototypes;

public static class CMPrototypeExtensions
{
    public static bool FilterCM = true;

    public static IEnumerable<T> EnumerateCM<T>(this IPrototypeManager prototypes) where T : class, IPrototype
    {
        var protos = prototypes.EnumeratePrototypes<T>();
        return protos;
    }

    public static bool TryCM<T>(this IPrototypeManager prototypes, string id, [NotNullWhen(true)] out T? prototype) where T : class, IPrototype
    {
        prototype = default;

        if (!prototypes.TryIndex(id, out T? proto))
            return false;

        prototype = proto;
        return true;
    }
}
