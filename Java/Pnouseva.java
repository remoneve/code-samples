/**
 * @author remon
 *
 */
public class Pnouseva {
    
    /**
     * Testataan Pnouseva-luokkaa
     * ENG: Testing Pnouseva-class
     * @param args ei käytössä
     */
    public static void main(String[] args)  {
        System.out.println(pisinNouseva("abajiuxc"));
        System.out.println(pisinNouseva("kissa"));
        System.out.println(pisinNouseva("abcdefg"));
        System.out.println(pisinNouseva("dcba"));
        System.out.println(pisinNouseva("ab"));
        System.out.println(pisinNouseva("a"));
        System.out.println(pisinNouseva(""));
      }
    
    /**
     * Etsitään merkkijonosta suurin jono, jossa seuraava kirjain on edeltäväänsä "suurempi" tai "samanarvoinen" aakkosjärjestyksessä.
     * ENG: Find longest line of characters where the next char is equal or "bigger" than the previous (as in alphabetical order).
     * @param merkkijono jono merkkejä
     * @return suurimman nousevan jonon pituus
     * @example
     * <pre name="test">
     * pisinNouseva("abajiuxac") === 3;
     * pisinNouseva("kissa") === 3;
     * pisinNouseva("") === 0;
     * </pre>
     */
    public static int pisinNouseva(String merkkijono) {
        if ( merkkijono.length() < 1) { return 0; }
        int pisin = 1;
        int jono = 1;
        for (int i = 1; i < merkkijono.length(); i++) {
            char c1 = merkkijono.charAt(i-1);
            char c2 = merkkijono.charAt(i);
            if (c1 <= c2) { 
                jono++;
                if (jono > pisin) { 
                    pisin = jono;
                    }
                }
            else {
                if (jono > pisin) { 
                    pisin = jono;
                    }
                jono = 1;
            }
        }
        return pisin;
    }
}
