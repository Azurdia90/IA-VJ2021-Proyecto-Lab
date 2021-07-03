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

    List<string> pisos = new List<string>() { "madera rustico", "madera oscuro", "madera clara", "madera gris", "alfombre girs con morado", "baldosas con diseno" };
    List<string> iluminacion = new List<string>() { "Verde", "Azul", "Amarillo"};
    List<string> posiciones = new List<string>() { "superior izquierda", "superior derecha", "centro", "inferior izquierda", "inferior dererecha" };
    List<string> paredes = new List<string>() { "Pared 1", "Pared 2"};


    // Start is called before the first frame update
    void Start()
    {
       ddPiso.AddOptions(pisos);
       ddIluminacion.AddOptions(iluminacion);
       ddEscritorio.AddOptions(posiciones);
       ddSilla.AddOptions(posiciones);
       ddCuadro.AddOptions(paredes);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Bienvenida");
    }

    public void CrearEspacio()
    {
        principal.CrearEspacio();
    }
}
