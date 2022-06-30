namespace dz3
{
class Program
{
static void Main(string[] args)
{
    
    Console.WriteLine("Введите цифру, обозначающую день недели ");
    int number = Convert.ToInt32(Console.ReadLine());
    if ( 1 <= number && number <= 7)
    {
        if ( number != 6 && number != 7 )
        { 
            Console.WriteLine("Этот день НЕ является выходным");
        }

        else Console.WriteLine("Этот день является выходным");
    }
    else Console.WriteLine(" Нет такого дня недели");

}
}
}