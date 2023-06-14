Console.Clear();
Console.Write("Введите первое целое число:");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);

Console.Write("Введите второе целое число:");
string userInput2 = Console.ReadLine() ?? "";
int b = int.Parse(userInput2);

if (a > b)
{
    Console.WriteLine($"{a}->max");
    Console.WriteLine($"{b}->min");
}
else
{
    Console.WriteLine($"a = {a}-> min");
    Console.WriteLine($"b = {b}-> max");
}
