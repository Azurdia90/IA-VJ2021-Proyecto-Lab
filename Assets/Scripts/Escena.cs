using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escena 
{
    private string name;
    private int piso;
    private int iluminacion;
    private int escritorio;
    private int silla;
    private int cuadre;
    private int indexPiso;

    public Escena(int nivel)
    {
        this.name = "Escena " + nivel;
        this.piso = 0;
        this.iluminacion = 0;
        this.escritorio = 0;
        this.silla = 0;
        this.cuadre = 0;
        this.indexPiso = 0;
    }

}
