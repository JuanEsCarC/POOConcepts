
using POO.Concepts.Core;


try
{
    var employee_1 = new SalaryEmployee { Id = 1010, FirstName = "Juan", LastName = "Cardenas", BornDate = new Date(1985, 11, 02), 
        HireDate = new Date(2021, 5, 18), IsActive = true, Salary = 2000000 };
    var employee_2 = new HourlyEmployee { Id = 2010, FirstName = "Pedro", LastName = "Perez", BornDate = new Date(1987, 06, 03), 
        HireDate = new Date(2024, 1, 1), IsActive = true, HourValue = 35000, WorkingHours = 120 };

    var employers = new List<Employee> { employee_1, employee_2 };
    decimal Total = 0;

    foreach (var employee in employers)
    {
        Console.WriteLine(employee);
        Total += employee.GetValueToPay();
    }

    Console.WriteLine("============================");
    Console.WriteLine($"TOTAL: {Total:C2}");

}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);    
}