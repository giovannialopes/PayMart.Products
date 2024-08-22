using System;

namespace PayMart.Application.Products.Utilities;

public static class NumberGenerator
{
    private static readonly Random _random = new Random();
    private static int _lastGeneratedNumber;

    public static int Generate()
    {
        int newNumber;
        do
        {
            newNumber = _random.Next(1000);
        } while (newNumber == _lastGeneratedNumber);

        _lastGeneratedNumber = newNumber;
        return newNumber;
    }
}
