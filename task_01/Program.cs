namespace task_01
{
class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Введите пятизначное  число");    
    string? str = Convert.ToString(Console.ReadLine());
    if (str != null)
    {   
        if (str.Length == 5) 
        {
            int i = 0;
            int length = str.Length-1; 
            if (str[i] == str[length])
            {
                if (str[i++] == str[length--])
                {
                    Console.WriteLine($"Число {str} является палиндромом");
                } 
            }   
            else Console.WriteLine($"Число {str} НЕ является палиндромом");
        }  
        else Console.WriteLine($"Число {str} не пятизначное"); 
    }
    }
}
}