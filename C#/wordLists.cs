using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Listat
{
    public static void Main()
    {
        List<string> sanat = new List<string> { "susi", "kissa", "kissa", "kana", "koira", "mato", "t�i", "kissa" };
        Console.WriteLine(string.Join(" ", sanat));

        string pisin = EtsiPisin(sanat);
        Console.WriteLine(pisin);
        PoistaSanat(sanat, pisin);
        Console.WriteLine(string.Join(" ", sanat));
    }


    /// <summary>
    /// Aliohjelma etsii listan pisimmän sanan
    /// ENG: Method finds the longest word in list.
    /// </summary>
    /// <param name="sanat">Annettu lista sanoja</param>
    /// <returns>Pisimmän sanan</returns>
    /// <example>
    /// <pre name="test">
    /// List<string> sanat1 = new List<string>{ "olo", "hali", "konna", "leppakerttu", "koira", "mato", "t�i", "kissa" };
    /// EtsiPisin(sanat1) === "leppakerttu"
    /// List<string> sanat2 = new List<string>{ "olo", "hali", "konna", "leppakerttu", "koira", "matoautokala", "t�i", "kissa" };
    /// EtsiPisin(sanat2) === "matoautokala"
    /// List<string> sanat3 = new List<string>{ "olo", "hal", "tai" };
    /// EtsiPisin(sanat3) === "olo"
    /// </pre>
    /// </example>
    public static string EtsiPisin(List<string> sanat)
    {
        int i = 0;
        string pisin = "";
        while (i < sanat.Count)
        {
            if (sanat[i].Length > pisin.Length)
            {
                pisin = sanat[i];
            }
            i++;
        }
        return pisin;
    }

    /// <summary>
    /// Aliohjelma poistaa sille annetut sanat listasta
    /// ENG: Method removes words given as parameters from list.
    /// </summary>
    /// <param name="sanat">Lista sanoja</param>
    /// <param name="pisin">Annettu sana</param>
    /// <example>
    /// <pre name="test">
    /// List<string> sanat1 = new List<string>{ "olo", "hali", "konna", "leppakerttu", "koira", "mato", "tai", "kissa" };
    /// PoistaSanat(sanat1, "leppakerttu");
    /// String.Join(" ", sanat1) === "olo hali konna koira mato tai kissa";
    /// List<string> sanat2 = new List<string>{ "olo", "hali", "konna", "leppakerttu", "koira", "matoautokala", "tai", "kissa" };
    /// PoistaSanat(sanat2, "matoautokala");
    /// String.Join(" ", sanat2) === "olo hali konna leppakerttu koira tai kissa";
    /// List<string> sanat3 = new List<string>{ "olo", "hal", "tai" };
    /// PoistaSanat(sanat3, "olo");
    /// String.Join(" ", sanat3) === "hal tai";
    /// </pre>
    /// </example>
    public static void PoistaSanat(List<string> sanat, string pisin)
    {
        int i = 0;
        while (i < sanat.Count)
        {
            if (sanat[i] == pisin)
            {
                sanat.RemoveAt(i);
                i--;
            }
            i++;
        }
    }
}