using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;

public class BaseComissionEmployee : ComissionEmployee
{
    //Fields

    private const decimal SALARY_BASE = 300000;
    private decimal _salaryBase;

    //Properties
    public decimal SalaryBase
    {
        get => _salaryBase;
        set => _salaryBase = ValidateSalaryBase(value);
    }

    //Methods

    override public decimal GetValueToPay()
    {
        return  base.GetValueToPay() + SalaryBase;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"*Salary Base.: {SalaryBase,20:C0}";
    }

    private decimal ValidateSalaryBase(decimal salaryBase)
    {

        if (salaryBase < SALARY_BASE)
        {
            throw new Exception($"The salary base: {salaryBase:C0}, is less than the minimum salary ({SALARY_BASE:C0})");
        }
        return salaryBase;
    }


}
