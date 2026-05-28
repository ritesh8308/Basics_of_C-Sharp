// QUEUE — First In First Out (FIFO) — like a line at a shop
Queue<string> queue = new Queue<string>();
queue.Enqueue("Customer 1");   // add to back
queue.Enqueue("Customer 2");
queue.Enqueue("Customer 3");

Console.WriteLine(queue.Peek());    // see front without removing
Console.WriteLine(queue.Dequeue()); // remove from front → Customer 1
Console.WriteLine(queue.Count);     // 2

// STACK — Last In First Out (LIFO) — like a stack of plates
Stack<string> stack = new Stack<string>();
stack.Push("Page 1");   // add to top
stack.Push("Page 2");
stack.Push("Page 3");

Console.WriteLine(stack.Peek());   // see top without removing → Page 3
Console.WriteLine(stack.Pop());    // remove from top → Page 3
Console.WriteLine(stack.Count);    // 2