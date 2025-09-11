using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;

public class Invoice : IPay
{

    //Properties

    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public float Quantity { get; set; }


    //Methods

    public decimal GetValueToPay()
    {
        return  Price * (decimal)Quantity;
    }

    public override string ToString()
    {
        return
            $"{Id}\t{Description}\n\t" +
            $"Quantity.....: {Quantity,20:N2}\n\t" +
            $"Price........: {Price,20:C0}\n\t" +
            $"Value to pay.: {GetValueToPay(),20:C0}";

    }

}
