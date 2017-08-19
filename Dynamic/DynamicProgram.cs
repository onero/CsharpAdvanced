using System;

namespace Dynamic
{
    static class DynamicProgram
    {
        static void Main(string[] args)
        {
            // Define dynamic value as string
            dynamic value = "Adam";

            // Change it to integer!
            value = 10;

            // No worries...
            Console.WriteLine(value);

            // Define two dynamic numbers
            dynamic numberA = 5;
            dynamic numberB = 5;

            // Define result of two dynamics
            var result = numberA + numberB;

            // Get dynamic result!
            Console.WriteLine(result);
        }
    }
}
