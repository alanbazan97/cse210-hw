using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a fraction using the 1° constructor
        Fraction fraction1 = new Fraction();
        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Fraction 1 decimal value: " + fraction1.GetDecimalValue());

        //Create a fraction using the 2° constructor
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine("Fraction 2: " + fraction2.GetFractionString());
        Console.WriteLine("Fraction 2 decimal value: " + fraction2.GetDecimalValue());

        //Create a fraction using the 3° constructor
        Fraction fraction3 = new Fraction(6,7);
        Console.WriteLine("Fraction 2: " + fraction3.GetFractionString());
        Console.WriteLine("Fraction 2 decimal value: " + fraction3.GetDecimalValue());

        //Create a second fraction using the 3° constructor
        Fraction fraction4 = new Fraction(6,7);
        Console.WriteLine("Fraction 2: " + fraction4.GetFractionString());
        Console.WriteLine("Fraction 2 decimal value: " + fraction4.GetDecimalValue());

        Console.ReadLine();
    }
}