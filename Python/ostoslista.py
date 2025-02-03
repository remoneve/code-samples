# Tällä ohjelmalla voi ylläpitää yksinkertaista ostoslistaa.
# ENG: With this program, you can upkeep a simple shopping list.

def paaohjelma():
    ostoslista = []
    while (True):
        print("Ostoslistasi sisältää seuraavat tuotteet:")
        print(ostoslista)

        print("Voit valita alla olevista toiminnoista:")
        print("1) Lisää")
        print("2) Poista")
        print("0) Lopeta")
        valinta = int(input("Valintasi: "))

        if (valinta == 0):
            print("Sinulta jäi ostamatta seuraavat tuotteet:")
            print(ostoslista)
            break
        elif (valinta == 1):
            tuote = input("Anna lisättävä tuote: ")
            print()
            ostoslista.append(tuote)
        elif (valinta == 2):
            print("Ostoslistassasi on", str(len(ostoslista)), "tuotetta.")
            poistettava = int(input("Anna poistettavan tuotteen järjestysnumero: "))
            print()
            del ostoslista[poistettava - 1]
        else:
            print("Tunnistamaton valinta.")
            print()

    print("Kiitos ohjelman käytöstä.")
    return None

paaohjelma()
