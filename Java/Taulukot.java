/**
 * @author remon
 *
 */
public class Taulukot {

   /**
    * @param args ei käytössä
    */
public static void main(String[] args) {
    int taulukko[][]  = { {25,10,2,2,}, {22,3,2,1} };
    System.out.println(matriisinSuurin(taulukko));
   }

   /**
    * Palautetaan suurin matriisista
    * ENG: return the largest item from matrix.
    * @param taulukko kaksiulotteinen taulukko
    * @return suurin alkion arvo
    * @example
    * <pre name="test">
    * int t[][]  = { {1,2,3,4,5}, {1,23,4,2,15} };
    * matriisinSuurin(t) === 23;
    * int t2[][]  = { {}, {} };
    * matriisinSuurin(t2) === 0;
    * int t3[][]  = { {-2, -3, -4, -1, -2}, {-2} };
    * matriisinSuurin(t3) === -1;
    * </pre>
    */
    public static int matriisinSuurin(int[][] taulukko) {
       if (taulukko[0].length <= 0 && taulukko[1].length <= 0) return 0;
       int suurin = taulukko[0][0];
       int rivi = taulukko.length;
       for (int i = 0; i < rivi; i++) {
           
           int sarake = taulukko[i].length; 
           
           for (int j = 0; j < sarake; j++) {
               
               if (taulukko[i][j] > suurin) {
                   
                   suurin = taulukko[i][j];
                   }
               }
           }
       return suurin;
    }
}