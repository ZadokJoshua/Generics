var stack = new SimpleStack();
stack.Push(1.2);
stack.Push(3.8);
stack.Push(3.0);

while(stack.Count > 0)
{
    double item = stack.Pop();
}
