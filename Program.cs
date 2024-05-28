using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap co so: ");
        int co_so = int.Parse(Console.ReadLine());

        Console.Write("Nhap so mu: ");
        int mu = int.Parse(Console.ReadLine());

        Console.WriteLine($"{co_so}^{mu} = {Math.Pow(co_so, mu)}");
    }
}