
using POO.Concepts.Core;


try
{
    var date_1 = new Date();
    var date_2 = new Date(2025, 14, 15);

    Console.WriteLine(date_1.ToString());
    Console.WriteLine(date_2.ToString());
}
catch (Exception ex)
{ 
    Console.WriteLine($"Error: {ex.Message}");    
}