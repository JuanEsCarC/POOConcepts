using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;
public class ComissionEmployee : Employee
{
    //Fields

    private float _comissionPercentaje;

    private decimal _sales;

    //Properties
    public float ComissionPercentaje 
    { 
        get => _comissionPercentaje; 
        set => _comissionPercentaje = ValidateComissionPercentaje(value);
    }

    public decimal Sales 
    { 
        get => _sales; 
        set => _sales = ValidateSales(value);
    }

    //Methods
    public override decimal GetValueToPay()
    {
        return Sales * (decimal) ComissionPercentaje;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Sales........: {Sales,20:C2}\n\t" +
            $"Comission_%..: {ComissionPercentaje,20:P2}\n\t" +
            $"Salary.......: {GetValueToPay(),20:C0}";
    }

    private float ValidateComissionPercentaje (float comissionPercentaje)
    {
        if (comissionPercentaje < 0 || comissionPercentaje > 100)
        {
            throw new Exception ($"The comission percentaje: {comissionPercentaje:P2}, is invalid");
        }
        return comissionPercentaje;
    }

    private Decimal ValidateSales(Decimal sales)
    {
        if (sales < 0)
        {
            throw new Exception($"The sales: {sales:C2}, is less than zero. Validate posible devolutions");
        }
        return sales;
    }



}

