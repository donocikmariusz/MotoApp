
var stack = new Stack<double>();
stack.Push(4.5);
stack.Push(43);
stack.Push(333.6);

var stackString = new Stack<string>();
stackString.Push("parch");
stackString.Push("parch2");
stackString.Push("parch3");

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

while (stackString.Count > 0)
{
    string item = stackString.Pop();
    Console.WriteLine($"Item: {item}");
}



Console.WriteLine($"Sum: {sum}");