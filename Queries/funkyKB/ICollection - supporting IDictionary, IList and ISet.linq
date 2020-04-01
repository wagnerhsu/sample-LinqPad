<Query Kind="Program" />

void Main()
{
    IList<string> flexibleOne = new MyThings().Things.ToList();
    flexibleOne.Dump(nameof(flexibleOne));

    IDictionary<int, string> flexibleOtherOne = new MyOtherThings().Things.ToDictionary(pair => pair.Key, pair => pair.Value);
    flexibleOtherOne.Dump(nameof(flexibleOtherOne));

    ISet<string> flexibleSet = new MyThings().Things.ToHashSet();
    flexibleSet.Dump(nameof(flexibleSet));
}

public interface IFlexible<T>
{
    ICollection<T> Things { get; }
}

class MyThings : IFlexible<string>
{
    public MyThings()
    {
        this.Things = new[] { "thing one", "thing two", "thing two" };
    }

    public ICollection<string> Things { get; }
}

class MyOtherThings : IFlexible<KeyValuePair<int, string>>
{
    public MyOtherThings()
    {
        this.Things = new[]
        {
            new KeyValuePair<int, string>(1, "one"),
            new KeyValuePair<int, string>(2, "two"),
        };
    }

    public ICollection<KeyValuePair<int, string>> Things { get; }
}

/*
    “The ICollection<T> interface is the base interface
    for classes in the System.Collections.Generic namespace.
    …
    If neither the IDictionary<TKey,TValue> interface
    nor the IList<T> interface meet the requirements of the required collection,
    derive the new collection class from the ICollection<T> interface instead
    for more flexibility.”

    📖 [ https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?view=netstandard-2.1 ]

    “A HashSet<T> collection is not sorted and cannot contain duplicate elements.”
    📖 [ https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=netstandard-2.1 ]
*/