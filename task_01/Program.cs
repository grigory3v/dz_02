namespace task_01
{
class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Введите трехзначное число");    
    string? str = Convert.ToString(Console.ReadLine());
    if (str != null)
    {
        int number = Convert.ToInt32(str);
        if ( 99 < number && number < 1000)
        {
          
            Console.Write(str[1]);
        }
    }
        else Console.WriteLine("Вы ввели неверное число");
}
}
}
