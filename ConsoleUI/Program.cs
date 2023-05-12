
using ConsoleUI;

string name = "";
try
{
    Methods.DifferentMethod();

    Console.Write("What is your name: ");
    name = Console.ReadLine();
    Methods.ComplexMethod(name);
    Methods.SimpleMethod();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("You should not be calling these methods.");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException)
{
    Console.WriteLine("You forgot to finish your code!");
}
catch (Exception) when (name.ToLower() == "tim")
{
    Console.WriteLine("You used Tim's name, didn't you?");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    //Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("I always run");
}
