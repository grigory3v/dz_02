namespace task_01
{
class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Введите число");    
    string? str = Convert.ToString(Console.ReadLine());
    if (str != null)
    {
        if (str.Length <= 2)
        {
        Console.WriteLine("третьей цифры нет");
        } 
        else Console.Write(str[2]);
    }
}
}
}