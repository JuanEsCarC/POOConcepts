
using POO.Concepts.Core;


try
{
    var employee_1 = new SalaryEmployee { Id = 1010, FirstName = "Juan", LastName = "Cardenas", BornDate = new Date(1985, 11, 2), 
        HireDate = new Date(2021, 5, 18), IsActive = true, Salary = 2000000 };
    var employee_2 = new HourlyEmployee { Id = 2030, FirstName = "Pedro", LastName = "Perez", BornDate = new Date(1987, 6, 3), 
        HireDate = new Date(2024, 1, 1), IsActive = true, HourValue = 35000, WorkingHours = 120 };
    var employee_3 = new ComissionEmployee { Id = 3030, FirstName = "Maria", LastName = "Correa", BornDate = new Date(1986, 1, 28), 
        HireDate = new Date(2020, 9, 15), IsActive = true, Sales = 350000000, ComissionPercentaje = 0.02f };
    var employee_4 = new BaseComissionEmployee { Id = 4040, FirstName = "Lina", LastName = "Molina", BornDate = new Date(1990, 3, 15), 
        HireDate = new Date(2025, 2, 20), IsActive = true, Sales = 100000000, ComissionPercentaje = 0.01f, SalaryBase = 500000 };

    var invoice_1 = new Invoice { Id = 1, Description = "Iphone 15", Quantity = 2, Price = 3500000 };
    var invoice_2 = new Invoice { Id = 2, Description = "Macbook Pro", Quantity = 1, Price = 8500000 };
    var invoice_3 = new Invoice { Id = 3, Description = "Airpods Pro", Quantity = 4, Price = 800000 };


    var items = new List<IPay> { employee_1, employee_2, employee_3, employee_4, invoice_1, invoice_2, invoice_3 };
    decimal Total = 0;

    foreach (var item in items)
    {
        Console.WriteLine(item);
        Console.WriteLine();
        Total += item.GetValueToPay();
    }

    Console.WriteLine("                      =====================");
    Console.WriteLine($"TOTAL                  {Total,20:C2}");

}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}