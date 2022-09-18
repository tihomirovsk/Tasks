Console.WriteLine("Введите число : ");
string input = Console.ReadLine();
int number = int.Parse(input);

int odd = 1;
int even = 2;


if (number / even == even )
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}