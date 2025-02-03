# ENG: Simple program that reads one file and writes its contents to another file.

import sys

def tiedoston_luku(nimi):
    lista = []
    rivit = 0
    try:
        tiedosto = open(nimi, "r")
        while (True):
            rivi = tiedosto.readline()
            if (rivi == ""):
                break
            lista.append(rivi)
            rivit += 1
        tiedosto.close()
        print("Tiedoston '{0}' lukeminen onnistui, {1} riviä.".format(nimi, rivit))
        return lista
    except Exception:
        print("Tiedoston '{0}' käsittelyssä virhe, lopetetaan.".format(nimi))
        sys.exit(0)

def tiedoston_kirjoitus(nimi, lista):
    try:
        tiedosto = open(nimi, "w")
        for rivi in lista:
            tiedosto.write(rivi)
            
        tiedosto.close()
        print("Tiedoston '{0}' kirjoittaminen onnistui.".format(nimi))
    except Exception:
        print("Tiedoston '{0}' käsittelyssä virhe, lopetetaan.".format(nimi))
        sys.exit(0)


def paaohjelma():
    lista = tiedoston_luku(input("Anna luettavan tiedoston nimi: "))
    tiedoston_kirjoitus(input("Anna kirjoitettavan tiedoston nimi: "), lista)
    print("Kiitos ohjelman käytöstä.")
    return None
    
paaohjelma()
