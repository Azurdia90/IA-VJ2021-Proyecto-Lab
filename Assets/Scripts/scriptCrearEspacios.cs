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

    
    void Awake()
    {
        
        if(ddPiso != null )
        {
            List<string> pisos = new List<string>() { "piso1", "piso2", "piso3"};
            ddPiso.ClearOptions();
            ddPiso.AddOptions(pisos);
        }

        if(ddIluminacion != null)
        {
            List<string> iluminacion = new List<string>() { "Verde", "Azul", "Rojo"};
            ddIluminacion.ClearOptions();
            ddIluminacion.AddOptions(iluminacion);
        }

        if(ddEscritorio != null )
        {
            List<string> posiciones = new List<string>() { "superior izquierda", "superior derecha", "centro", "inferior izquierda", "inferior dererecha" };
            ddEscritorio.ClearOptions();
            ddEscritorio.AddOptions(posiciones);
        }
            
        if(ddSilla != null)
        {
            List<string> posiciones = new List<string>() { "superior izquierda", "superior derecha", "centro", "inferior izquierda", "inferior dererecha" };
            ddSilla.ClearOptions();
            ddSilla.AddOptions(posiciones);
        }

        if(ddCuadro != null)
        {
            List<string> paredes = new List<string>() { "Pared 1", "Pared 2"};
            ddCuadro.ClearOptions();
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
