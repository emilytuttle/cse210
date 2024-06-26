using System;

public class Fraction
{
    private int _topNum;
    private int _bottomNum = 1;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int oneNum)
    {
        _topNum = oneNum;
    }

    public Fraction(int numOne, int numTwo)
    {
        _topNum = numOne;
        _bottomNum = numTwo;
    }

    public string GetFractionString()
    {
        string fraction = $"{_topNum}/{_bottomNum}";
        return fraction;
    }

    public double GetDecimal()
    {
       return (double)_topNum / (double)_bottomNum;
       
    }
}
