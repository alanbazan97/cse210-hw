using System;

//Create the Fraction Class
public class Fraction
{
    private int _top;
    private int _bottom;

    //Create the Constructors
    public Fraction()
    {
        _top = 1; 
        _bottom = 1;
    }  
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber; 
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top; 
        _bottom = bottom;
    }
    //Creat Getters and Setters Top
    public string GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    //Creat Getters and Setters Bottom
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    // Method to return the fraction as a string in the form "3/4"
    public string GetFractionString()
    {
        return _top.ToString() + "/" + _bottom.ToString();
    }

    // Method to return the decimal value of the fraction as a double
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}



    