class Counter
{
    // Instance — each object has its OWN copy
    public int Count { get; set; }

    // Static — ONE copy shared across ALL objects
    public static int TotalCreated { get; private set; }

    public Counter()
    {
        Count = 0;
        TotalCreated++;    // increments the shared counter
    }

    public void Increment() { Count++; }
}

Counter c1 = new Counter();
Counter c2 = new Counter();
Counter c3 = new Counter();

c1.Increment();
c1.Increment();
c2.Increment();

Console.WriteLine(c1.Count);           // 2 — c1's own count
Console.WriteLine(c2.Count);           // 1 — c2's own count
Console.WriteLine(Counter.TotalCreated); // 3 — shared, access via class name