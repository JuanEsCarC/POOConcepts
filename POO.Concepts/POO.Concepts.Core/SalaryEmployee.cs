using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;

public class SalaryEmployee : Employee
{

    //Fields
    private const decimal MINIMUM_SALARY = 1500000;
    
    private decimal _salary;


    //Public Properties
    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalary(value); 
    }

    //Methods
    public override decimal GetValueToPay()
    {
        return Salary;
    }
    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Salary.....: {GetValueToPay():C0}";
    }

    private decimal ValidateSalary(decimal salary)
    {

        if (salary < MINIMUM_SALARY)
        {
            throw new Exception ($"The salary: {salary:C0}, is less than the minimum salary ({MINIMUM_SALARY:C0})");
        }
        return salary;
    }



}
