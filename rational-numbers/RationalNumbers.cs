using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    private static double Root(double A, int N)
    {
        return Math.Pow(A, 1.0 / N);
    }

    public static double Expreal(this int realNumber, RationalNumber r)
    {
        var root = Root(Math.Pow(realNumber, r.numerator), r.denominator);
        return root;
    }
}

public struct RationalNumber
{
    public int numerator, denominator;

    public RationalNumber(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        var result = new RationalNumber((r1.numerator * r2.denominator) + (r1.denominator * r2.numerator), r1.denominator * r2.denominator).Reduce();
        return result;
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        var result = new RationalNumber((r1.numerator * r2.denominator) - (r1.denominator * r2.numerator), r1.denominator * r2.denominator).Reduce();
        return result;
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        var result = new RationalNumber(r1.numerator * r2.numerator, r1.denominator * r2.denominator).Reduce();
        return result;
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        var result = new RationalNumber(r1.numerator * r2.denominator, r1.denominator * r2.numerator).Reduce();
        return result;
    }

    public RationalNumber Abs()
    {
        var result = new RationalNumber(Math.Abs(numerator), Math.Abs(denominator)).Reduce();
        return result;
    }

    public RationalNumber Reduce()
    {
        bool isNegative = false;
        if (denominator < 0)
            isNegative = true;
        var i = Math.Abs(denominator);
        while(true)
        {
            if(numerator % i == 0 && denominator % i ==0)
            {
                break;
            }
            i--;
        }
        var newNum = (isNegative ? -numerator : numerator) / i;
        var newDen = (isNegative ? Math.Abs(denominator) : denominator) / i;
        var result = new RationalNumber(newNum, newDen);
        return result;
        
    }

    public RationalNumber Exprational(int power)
    {
        if (power > 0)
            return new RationalNumber((int)Math.Pow(numerator, power), (int)Math.Pow(denominator, power)).Reduce();
        else if (power < 0)
            return new RationalNumber((int)Math.Pow(denominator, Math.Abs(power)), (int)Math.Pow(numerator, Math.Abs(power))).Reduce();
        else return new RationalNumber(1, 1);
    }

    public double Expreal(int baseNumber)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}