using System;
using System.Text;

public class Demo11
{
    public static void Main()
    {
        int[] t = { 3, 1, -7, 9, 15, 8 };
        int toiseksiSuurin = EtsiToiseksiSuurin(t);
        TulostaTaulukko(t, toiseksiSuurin);
        t = new int[] { 1, 2, 3, 4 };
        toiseksiSuurin = EtsiToiseksiSuurin(t);
        TulostaTaulukko(t, toiseksiSuurin);
        t = new int[] { 7, 10, 8, 2 };
        toiseksiSuurin = EtsiToiseksiSuurin(t);
        TulostaTaulukko(t, toiseksiSuurin);
        t = new int[] { 1, 223 };
        toiseksiSuurin = EtsiToiseksiSuurin(t);
        TulostaTaulukko(t, toiseksiSuurin);
        t = new int[] { -1, -223 };
        toiseksiSuurin = EtsiToiseksiSuurin(t);
        TulostaTaulukko(t, toiseksiSuurin);
    }

    /// <summary>
    /// Aliohjelma etsii annetusta taulukosta toisiksi suurimman alkion
    /// ENG: Method finds the second largest item from given list.
    /// </summary>
    /// <param name="taulukko">Ohjelmalle annettu taulukko lukuja</param>
    /// <returns>Toiseksi suurin alkio</returns>
    /// <example>
    /// <pre name="test">
    /// int[] taulukko1 = { 1, 2, 3, 4, 5 };
    ///  EtsiToiseksiSuurin(taulukko1) === 4;
    /// int[] taulukko2 = { 1, 1, 1, 1, 1 };
    ///  EtsiToiseksiSuurin(taulukko2) === 1;
    /// int[] taulukko3 = { 1, 2, 1, 2, 1 };
    ///  EtsiToiseksiSuurin(taulukko3) === 2;
    /// int[] taulukko4 = { 0, 0 };
    ///  EtsiToiseksiSuurin(taulukko4) === 0;
    ///  int[] taulukko5 = { };
    ///  EtsiToiseksiSuurin(taulukko5) === int.MinValue;
    ///  int[] taulukko6 = { 1 };
    ///  EtsiToiseksiSuurin(taulukko6) === int.MinValue;
    /// </pre>
    /// </example>
    public static int EtsiToiseksiSuurin(int[] taulukko)
    {
        int i = 0;
        int suurin = 0;
        int toiseksiSuurin = 0;

        if (taulukko.Length < 2)
        {
            return int.MinValue;
        }

        while (i < taulukko.Length)
        {
            if (i == 0)
            {
                suurin = taulukko[i];
            }

            if (suurin <= taulukko[i])
            {
                toiseksiSuurin = suurin;
                suurin = taulukko[i];
            }
            i++;
        }
        return toiseksiSuurin;
    }


    /// <summary>
    /// Aliohjelma tulostaa paaohjelmassa annetun taulukon seka taulukon toiseksi suurimman alkion
    /// ENG: Method prints given list and the second largest item.
    /// </summary>
    /// <param name="taulukko">Annettu taulukko lukuja</param>
    /// <param name="toiseksiSuurin">EtsiToiseksiSuurin -ohjelmassa etsitty toiseksi suurin alkio</param>
    public static void TulostaTaulukko(int[] taulukko, int toiseksiSuurin)
    {
        foreach (var item in taulukko)
        {
            Console.WriteLine("Taulukon " + string.Join(" ", taulukko) + " toiseksi suurin alkio on " + toiseksiSuurin);
        }
    }
}
