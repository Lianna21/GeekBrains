﻿double CalculateFormula(int a, int b, int c, int d)
{
    int numenator = a * b;
    double denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);

Console.WriteLine(result);