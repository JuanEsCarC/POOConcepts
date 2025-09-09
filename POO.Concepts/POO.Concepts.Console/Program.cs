
using POO.Concepts.Core;


try
{
    var employee_1 = new SalaryEmployee { Id = 1010, FirstName = "Juan", LastName = "Cardenas", BornDate = new Date(1985, 11, 02), HireDate = new Date(2021, 5, 18), IsActive = true, Salary = 2000000 };
    
    Console.WriteLine(employee_1);
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);    
}