System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    System.Console.WriteLine("Число " + number + " является четным");
}
else
{
    System.Console.WriteLine("Число " + number + " не является нечетным");
}