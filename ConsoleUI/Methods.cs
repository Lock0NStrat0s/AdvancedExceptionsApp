using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

public static class Methods
{
    public static void SimpleMethod()
    {
        throw new InvalidOperationException("You should not be calling the SimpleMethod");
    }

    public static void DifferentMethod()
    {
        Console.WriteLine("This is the different method working properly.");
    }

    public static void ComplexMethod(string name)
    {
        if (name.ToLower() == "tim")
        {
            throw new InsufficientMemoryException("Tim is too tall for this method.");
        }
        else
        {
            throw new ArgumentException("This person is not Tim.");
        }
    }
}
