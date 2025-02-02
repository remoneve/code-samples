using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Globalization;

public class MatriisienSumma
{
    public static void Main()
    {
     double[,] mat1 = { { 1, 2, 3 }, { 2, 2, 2 }, { 4, 2, 3 } };
     double[,] mat2 = { { 9, 2, 8 }, { 1, 2, 5 }, { 3, 19, -3 } };
     double[,] mat3 = Summa(mat1, mat2);
     Console.WriteLine(mat3[0, 0] + " " + mat3[0, 1] + " " + mat3[0, 2]);
     Console.WriteLine(mat3[1, 0] + " " + mat3[1, 1] + " " + mat3[1, 2]);
     Console.WriteLine(mat3[2, 0] + " " + mat3[2, 1] + " " + mat3[2, 2]);

    }
    /// <summary>
    /// Aliohjelma laskee yhteen kaksi samankokoista matriisia
    /// ENG: Method sums toghether two same-size matrixes.
    /// </summary>
    /// <param name="a">Ensimmäinen matriisi</param>
    /// <param name="b">Toinen matriisi</param>
    /// <returns>Matriisin jossa vastinalkiot ovat laskettuna yhteen</returns>
    /// <example>
    /// <pre name="test">
    /// double[,] mat1 = { { 1, 2, 3 }, { 2, 2, 2 }, { 4, 2, 3 } };
    /// double[,] mat2 = { { 9, 2, 8 }, { 1, 2, 5 }, { 3, 19, -3 } };
    /// double[,] m = Summa(mat1, mat2);
    /// m[0,0] === 10;
    /// m[2,2] ===  0;
    /// m[1,2] === 7;
    /// </pre>
    /// </example>
    public static double[,] Summa(double[,] a, double[,] b)
    {
     int riveja = a.GetLength(0);
     int sarakkeita = a.GetLength(1);
     double[,] m = new double[riveja, sarakkeita];
     for (int i = 0; i < riveja; i++)
          for (int x = 0; x < sarakkeita; x++)
                m[i, x] = a[i, x] + b[i, x];
     return m;
    }
}   