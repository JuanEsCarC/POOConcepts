using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;
public abstract class Employee
{

    //Public Properties
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = null!;
    public bool IsActive { get; set; }
    public Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;


    //Methods
    public abstract decimal GetValueToPay();

    public override string ToString()
    {
        return 
            $"{Id}\t{FirstName} {LastName}\n\t" +
            $"Hire date: {HireDate}\n\t" +
            $"Salary...: {GetValueToPay():C2}";
    }

}



