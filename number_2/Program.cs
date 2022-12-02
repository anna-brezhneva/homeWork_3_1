Console.Clear();
Console.Write("a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("b: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} - max");
}
else{
    Console.WriteLine($"{b} - max");
}
