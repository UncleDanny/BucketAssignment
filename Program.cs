using System;

namespace BucketAssignment
{
    class Program
    {
        static void Main()
        {
            RainBarrel barrel = new RainBarrel(10, BarrelSize.Medium);
            barrel.OnContainerOverflowing += (sender, e) => e.Cancel = true;
            barrel.Fill(120);
            Console.ReadLine();
        }
    }
}
