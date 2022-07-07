namespace task_02
{
class Program
{
static void Main(string[] args)
{
int Coordinates_x()
{   
    Console.WriteLine("x = ");    
    int x = Convert.ToInt32(Console.ReadLine());
    return x;  
}

int Coordinates_y()
{       
    Console.WriteLine("y = ");
    int y = Convert.ToInt32(Console.ReadLine());
    return y;
}

int Coordinates_z()
{      
    Console.WriteLine("z = ");
    int z = Convert.ToInt32(Console.ReadLine());
    return z; 
}

    Console.WriteLine("Введите координаты точки А");
    string coordinates_A = Convert.ToString(Coordinates_x())+';'+ Convert.ToString(Coordinates_y())+ ';' + Convert.ToString(Coordinates_z());

    Console.WriteLine("Введите координаты точки B");
    string coordinates_B = Convert.ToString(Coordinates_x())+';'+ Convert.ToString(Coordinates_y())+ ';' + Convert.ToString(Coordinates_z());
   
    string[] A = coordinates_A.Split(';');
    
            int ax = 0;
        if (int.TryParse(A[0], out ax)){}
            int ay = 0;
        if (int.TryParse(A[1], out ay)){}
            int az = 0;
        if (int.TryParse(A[2], out az)){}  
    
    string[] B = coordinates_B.Split(';');

            int bx = 0;
        if (int.TryParse(B[0], out bx)){}
            int by = 0;
        if (int.TryParse(B[1], out by)){}
            int bz = 0;
        if (int.TryParse(B[2], out bz)){}  

    double AB = (Math.Pow((bx-ax), 2)) + (Math.Pow((by-ay), 2)) + (Math.Pow((bz-az), 2));
   
    Console.WriteLine($" расстояние между AB в 3D пространстве = {Math.Round(Math.Sqrt(AB),2)}");
}
}
}