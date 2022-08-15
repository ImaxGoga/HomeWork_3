double distance3D(int ax, int ay, int az, int bx, int by, int bz)
{
    double res = Math.Sqrt(Math.Pow(bx - ax,2) + Math.Pow(by - ay,2) + Math.Pow(bz - az,2));
    return res;
    
}

Console.Write("Введите координату A_x: ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Введите координату A_y: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Введите координату A_z: ");
int az = int.Parse(Console.ReadLine());
Console.Write("Введите координату B_x: ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Введите координату B_y: ");
int by = int.Parse(Console.ReadLine());
Console.Write("Введите координату B_z: ");
int bz = int.Parse(Console.ReadLine());
double result = distance3D(ax,ay,az,bx,by,bz);
Console.WriteLine($"Расстояние между точками A и B в 3D пространстве: {Math.Round(result,2)}");

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53