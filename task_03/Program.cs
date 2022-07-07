namespace task_03
{
class Program
{
static void Main(string[] args)
{
    
    Console.WriteLine("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 1; i <= number; i++)
    {
    int n = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($" {n} " );
    }
    
}
}
}