using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;


public class HourlyEmployee: Employee
{

    //Fields

    private decimal _hourValue;
   
    private float _workingHours;


    //Properties

    public decimal HourValue 
    { 
        get => _hourValue; 
        set => _hourValue = ValidateHourValue(value); 
    }
    public float WorkingHours 
    { 
        get => _workingHours; 
        set => _workingHours = ValidateWorkingHours(value); 
    }


    //Methods
    
    public override decimal GetValueToPay()
    {
        return HourValue * (decimal)WorkingHours; //throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Working Hours: {WorkingHours,20:N2}\n\t" +
            $"Hour Value...: {HourValue,20:C2}\n\t" +
            $"Salary.......: {GetValueToPay(),20:C0}";
    }

    private decimal ValidateHourValue(decimal hourValue)
    {

        if (hourValue <= 0)
        {
            throw new Exception($"The hour value: {hourValue:C2}, is less or equals than zero");
        }
        return hourValue;
    }

    private float ValidateWorkingHours(float workinHours)
    {

        if (workinHours <= 0)
        {
            throw new Exception($"The working hours: {workinHours:N2}, is less or equals than zero");
        }
        return workinHours;
    }





}
