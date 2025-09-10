
using POO.Concepts.Core;


try
{
    var employee_1 = new SalaryEmployee { Id = 1010, FirstName = "Juan", LastName = "Cardenas", BornDate = new Date(1985, 11, 2), 
        HireDate = new Date(2021, 5, 18), IsActive = true, Salary = 2000000 };
    var employee_2 = new HourlyEmployee { Id = 2030, FirstName = "Pedro", LastName = "Perez", BornDate = new Date(1987, 6, 3), 
        HireDate = new Date(2024, 1, 1), IsActive = true, HourValue = 35000, WorkingHours = 120 };
    var employee_3 = new ComissionEmployee { Id = 3030, FirstName = "Maria", LastName = "Correa", BornDate = new Date(1986, 1, 28), 
        HireDate = new Date(2020, 9, 15), IsActive = true, Sales = 350000000, ComissionPercentaje = 0.02f };

    var employers = new List<Employee> { employee_1, employee_2, employee_3 };
    decimal Total = 0;

    foreach (var employee in employers)
    {
        Console.WriteLine(employee);
        Console.WriteLine();
        Total += employee.GetValueToPay();
    }

    Console.WriteLine("                      =====================");
    Console.WriteLine($"TOTAL                  {Total,20:C2}");

}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}