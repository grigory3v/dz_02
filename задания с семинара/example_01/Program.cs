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
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 1)
                {
                    continue;
                } 
            Console.Write(str[i]);
            }
        }
        else Console.WriteLine("Вы ввели неверное число");
    }
}
}
}