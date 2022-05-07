StackDoubles();
StackStrings();


static void StackDoubles()
{
    var stack = new SimpleStackDouble();
    stack.Push(1.2);
    stack.Push(3.8);
    stack.Push(3.0);

    double sum = 0.0;

    while (stack.Count > 0)
    {
        double item = (double)stack.Pop();
        Console.WriteLine($"Item: {item}");
        sum += item;
    }

    Console.WriteLine($"Sum: {sum}");
}

static void StackStrings()
{
    var stack = new SimpleStackString();
    stack.Push("Zadok is the boss");
    stack.Push("Merci, bien.");
    stack.Push("Joshua went to church.");

    while(stack.Count > 0)
    {
        Console.WriteLine(stack.Pop());
    }
}

Console.ReadLine();