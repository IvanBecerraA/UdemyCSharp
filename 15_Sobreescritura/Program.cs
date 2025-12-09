
A a = new B();
Console.WriteLine(a.Hi());

B b = new B();
Console.WriteLine(b.Hi());

Sale sale = new Sale(10);
sale.Add(2);
sale.Add(3);
Console.WriteLine(sale.GetTotal());

SalesWithTax salesWithTax = new SalesWithTax(10, 1.16m);
salesWithTax.Add(2);
salesWithTax.Add(3);
Console.WriteLine(salesWithTax.GetTotal());

public class Sale
{
    private decimal[] _amount;
    private int _n;
    private int _end;

    public Sale(int n)
    {
        _amount = new decimal[n];
        _n = n;
        _end = 0;
    }

    public void Add(decimal amount)
    {
        if (_end < _n)
        {
            _amount[_end++] = amount;
        }
    }

    public virtual decimal GetTotal()
    {
        decimal result = 0;
        int i = 0;
        while (i < _amount.Length)
        {
            result += _amount[i++];
        }

        return result;
    }
}


public class SalesWithTax : Sale
{
    private decimal _tax;
    public SalesWithTax(int n, decimal tax) : base(n) 
    {
        _tax = tax;        
    } 

    public override decimal GetTotal()
    {
        return base.GetTotal() * _tax;
    }
}



public class A
{
    public virtual string Hi()
    {
        return "Hola  soy A";
    }
}

public class B : A 
{
    public override string Hi()
    {
        return base.Hi() + "Hola soy B";
    }
}