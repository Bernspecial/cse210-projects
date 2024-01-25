using System;


// This is a fraction class that encapsulate the attribute of a fraction.
public class Fraction
 {
    // This the top numerator member variables set as private
    private int _top;
    // This is the bottom denominator member variables set as private, using this will hide the properties from the user.
    private int _bottom;

    // This is a constructor that has no required information.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    // This is a constructor that accept value for the top numerator
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // This is a constructor that accept value for the bottom denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    } 

    // This is a method that get the fraction value
    public string GetFraction()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    // Also, this a method that get the decimal value
    public double GetDecimalValue()
    {
        var decima = (double)_top / (double) _bottom;
        return decima;
        
    }
    
 }