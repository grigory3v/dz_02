   namespace task_02
{
class Program
{
static void Main(string[] args)
{
   
   
   int remainder = 0;
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if ( number1 % number2 == 0 ){
        Console.WriteLine($"Число {number2} является кратным числу {number1} ");
    }
    else Console.WriteLine($"Число {number2} НЕявляется кратным числу {number1}, остаток {remainder = number1 % number2} ");

}
}
}