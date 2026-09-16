using System;

class Program
{
    static void Main()
    {
        World world = new World();

        Console.WriteLine("================================");
        Console.WriteLine("       ROMANIA SMP");
        Console.WriteLine("================================");
        Console.WriteLine();
        Console.WriteLine("Joc pornit!");
        Console.WriteLine("WASD = miscare");
        Console.WriteLine();

        while (true)
        {
            world.Update(0.016f);
        }
    }
}