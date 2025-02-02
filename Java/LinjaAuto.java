import java.io.OutputStream;
import java.io.PrintStream;

/**
 * @author remon
 * Linja-auto -luokka, jossa on metodeja linja-autojen ja matkustajien käsittelyyn sekä tietojen tulostamiseen.
 * ENG: A class that has methods for managing buses and travellers and printing info.
 *
 */
public class LinjaAuto {

    private int paikkaMaara, paikkojaVapaana;
    
    /**
     * Alustetaan muodostaja
     * @param paikkaMaara Linja-autossa oleva kokonaispaikkojen määrä
     */
    public LinjaAuto(int paikkaMaara) {
        this.paikkaMaara = paikkaMaara;
        this.paikkojaVapaana = paikkaMaara;
    }
    
    /**
     * Metodi jolla kasvatetaan linja-autossa olevien matkustajien määrää
     * @param nousevatMatkustajat Kyytiin nousevien matkustajien määrä
     * @return palauttaa ylimääräiset matkustajat;
     * @example
     * <pre name="test">
     * LinjaAuto pieni = new LinjaAuto(30);
     * pieni.lisaa(2);
     * pieni.getTilaa() === 28;
     * LinjaAuto pienempi = new LinjaAuto(5);
     * pienempi.lisaa(7);
     * pienempi.getTilaa() === 0;
     * </pre>
     */
    public int lisaa(int nousevatMatkustajat) {
        int ylimaara = 0;
        if ((this.paikkojaVapaana - nousevatMatkustajat) >= 0) {
            this.paikkojaVapaana -= nousevatMatkustajat;
        }
        else {
            while (this.paikkojaVapaana > 0) {
                this.paikkojaVapaana--;
                ylimaara++;
            }
            ylimaara = nousevatMatkustajat - ylimaara;
        }
        return ylimaara;
    }
    
    
    /**
     * Metodi jolla vähennetään linja-autossa olevien matkustajien määrää
     * @param poistuvatMatkustajat Kyydistä poistuvien matkustajien määrä
     * @return palauttaa määrän jos matkustajia on vähennetty liikaa
     * @example
     * <pre name="test">
     * LinjaAuto pieni = new LinjaAuto(30);
     * pieni.lisaa(5);
     * pieni.getTilaa() === 25;
     * pieni.vahenna(2);
     * pieni.getTilaa() === 27;
     * </pre>
     */
    public int vahenna(int poistuvatMatkustajat) {
        if ((poistuvatMatkustajat + this.paikkojaVapaana) > this.paikkaMaara) {
            while (this.paikkojaVapaana < this.paikkaMaara) {
                this.paikkojaVapaana++;
            }
            return this.paikkaMaara - (poistuvatMatkustajat + this.paikkojaVapaana);
        }
        this.paikkojaVapaana += poistuvatMatkustajat;
        return 0;
    }
    
    
    /**
     * Metodi hakee vapaana olevien paikkojen määrän
     * @return Vapaana olevien paikkojen määrä
     * @example
     * <pre name="test">
     * LinjaAuto pieni = new LinjaAuto(30);
     * pieni.getTilaa() === 30;
     * </pre>
     */
    public int getTilaa() {
        return paikkojaVapaana;
    }
    
    
    /**
     * Metodi hakee vapaana olevien paikkojen määrän
     * @return Vapaana olevien paikkojen määrä
     * @example
     * <pre name="test">
     * LinjaAuto pieni = new LinjaAuto(30);
     * pieni.tilaa() === true;
     * </pre>
     */
    public boolean tilaa() {
        if (getTilaa() > 0) {
            return true;
        }
        return false;
    }
    
    
    /**
     * Metodi hakee linja-autossa olevien matkustajien määrän
     * @return Matkustajien määrä
     * @example
     * <pre name="test">
     * LinjaAuto pieni = new LinjaAuto(30);
     * pieni.lisaa(5);
     * pieni.getTilaa() === 25;
     * pieni.getMatkustajat() === 5;
     * pieni.vahenna(2);
     * pieni.getMatkustajat() === 3;
     * </pre>
     */
    public int getMatkustajat() {
        return paikkaMaara - getTilaa();
    }
    
    
    /**
     * Tulostetaan linja-auton tiedot
     * @param os tietovirta johon tiedot tulostetaan
     * @example
     * <pre name="test">
     * #import java.io.*;
     * ByteArrayOutputStream byteoutput = new ByteArrayOutputStream();
     * LinjaAuto pieni = new LinjaAuto(30);
     * pieni.tulosta(byteoutput);
     * byteoutput.toString() =R= "30,0,30\\s*"
     * </pre>
     */
    public void tulosta(OutputStream os) {
        PrintStream out = new PrintStream(os);
        out.println(paikkaMaara + "," + getMatkustajat() + "," + getTilaa());
    }
    
    
    /**
     * Testipääluokka linja-autoille
     * @param args ei käytössä
     */
    public static void main(String[] args) {
        LinjaAuto pikkubussi = new LinjaAuto(10);
        LinjaAuto isobussi = new LinjaAuto(45);
        pikkubussi.lisaa(4);    pikkubussi.tulosta(System.out); // 10,4,6
        isobussi.lisaa(30);     isobussi.tulosta(System.out);   // 45,30,15
        int yli = pikkubussi.lisaa(15);
        isobussi.lisaa(yli);
        pikkubussi.tulosta(System.out);                         // 10,10,0
        isobussi.tulosta(System.out);                           // 45,39,6
        if ( pikkubussi.getTilaa() > 0 )
            System.out.println("Pieneen bussiin mahtuu!");   // ei tulosta
        if ( isobussi.tilaa() )
            System.out.println("Isoon bussiin mahtuu!");     // tulostaa
        int vajaa = pikkubussi.vahenna(12);                  // vajaa = -2
        if ( vajaa < 0 )
            System.out.println("Pikkubussissa ei edes ole näin montaa!");
        pikkubussi.tulosta(System.out);                         // 10,0,10
    }

}
