using System;
using VideoApp;

namespace Nullable
{
    static class NullableProgram
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            DateTime date2;
            // Original implementation
            if (date != null)
            {
                date2 = date.GetValueOrDefault(); // GetValueOrDefault needed because it normally cannot be null!
            }
            else
            {
                date2 = DateTime.Today;
            }

            // Upgraded approach using ternary
            date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            // Hyper, modern, awesome coalescing approach
            date2 = date ?? DateTime.Today;

            Console.WriteLine($"date is null = {!date.HasValue}");
            Console.WriteLine($"date2 is therefore {date2}");
        }
    }
}
