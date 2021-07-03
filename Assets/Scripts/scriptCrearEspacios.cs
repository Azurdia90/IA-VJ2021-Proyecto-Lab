using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//mover entre escenas
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class scriptCrearEspacios : MonoBehaviour
{
    scriptPrincipal principal;
    public Dropdown  ddPiso;
    public Dropdown  ddIluminacion;
    public Dropdown  ddEscritorio;     
    public Dropdown  ddSilla;
    public Dropdown  ddCuadro;

    List<string> pisos = new List<string>() { "piso1", "piso2", "piso3"};
    List<string> iluminacion = new List<string>() { "Verde", "Azul", "Rojo"};
    List<string> posiciones = new List<string>() { "superior izquierda", "superior derecha", "centro", "inferior izquierda", "inferior dererecha" };
    List<string> paredes = new List<string>() { "Pared 1", "Pared 2"};

    void Awake()
    {
        if(ddPiso != null && ddIluminacion != null && ddEscritorio != null && ddSilla != null & ddCuadro != null)
        {
            ddPiso.AddOptions(pisos);
            ddIluminacion.AddOptions(iluminacion);
            ddEscritorio.AddOptions(posiciones);
            ddSilla.AddOptions(posiciones);
            ddCuadro.AddOptions(paredes);
        }
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Bienvenida");
    }

    public void CrearEspacio()
    {
        scriptPrincipal.GetInstance().crearEscena(ddPiso.value,ddIluminacion.value,ddEscritorio.value,ddSilla.value,ddCuadro.value,0);
    }
}
