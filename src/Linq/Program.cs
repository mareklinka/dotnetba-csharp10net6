static void PrintCollection(string label, IEnumerable e)
{
    Console.WriteLine(label);
    foreach (var i in e)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine();
}
static void PrintObject(string label, object o)
{
    Console.WriteLine(label);
    Console.WriteLine(o);
    Console.WriteLine();
}

var collection1 = Enumerable.Range(1, 20).Select(i => new { Name = $"Item {i}", Id = i, Partition = i % 7 });
var collection2 = Enumerable.Range(21, 50).Select(i => new { Name = $"Item {i}", Id = i, Partition = i % 13 });

PrintCollection("DistinctBy", collection1.DistinctBy(x => x.Partition));
PrintCollection("UnionBy", collection1.UnionBy(collection2, x => x.Partition));
PrintCollection("IntersectBy", collection1.IntersectBy(Enumerable.Range(3, 3), x => x.Partition));
PrintCollection("ExceptBy", collection1.ExceptBy(Enumerable.Range(3, 3), x => x.Partition));

PrintObject("MinBy", collection1.MinBy(x => x.Id));
PrintObject("MaxBy", collection2.MaxBy(x => x.Id));

var i = 1;
foreach (var c in Enumerable.Range(1, 101).Chunk(10))
{
    PrintCollection($"Chunk {i++}", c);
}

PrintObject("Default", collection2.FirstOrDefault(_ => _.Name == "Shepard", new { Name = "Not found", Id = -1, Partition = -1 }));

PrintObject("Third last", collection2.ElementAt(^3));
PrintCollection("Slice 1", collection2.Take(3..8));
PrintCollection("Slice 2", collection2.Take(12..));
PrintCollection("Slice 3", collection2.Take(3..^3));
PrintCollection("Slice 4", collection2.Take(^7..^3));

Console.ReadLine();