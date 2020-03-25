using System;

public class EqTriangle
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public EqTriangle() { }

    public EqTriangle( double a, double b, double c)
	{
        A = a;
        B = b;
        C = c;
	}

    public EqTriangle (EqTriangle anotherTriangle)
    {
        A = anotherTriangle.A;
        B = anotherTriangle.B;
        C = anotherTriangle.C;
    }

    public bool DoesThisTriangleExist()
    {
        if (A > 0 && B > 0 && C > 0 && A == B && A == C)
            return true;
        else
            return false;
    }

    public double Perimeter ()
    {
        if (DoesThisTriangleExist())
            return A + B + C;
        else
            return double.NaN;
    }

    public double Square()
    {
        if (DoesThisTriangleExist())
            return A * A * Math.Sqrt(3) / 4;
        else
            return double.NaN;
    }

}
