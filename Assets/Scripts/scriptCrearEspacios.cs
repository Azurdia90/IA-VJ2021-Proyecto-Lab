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
    public Dropdown  ddPiso;
    public Dropdown  ddIluminacion;
    public Dropdown  ddEscritorio;     
    public Dropdown  ddSilla;
    public Dropdown  ddCuadro;

    List<string> pisos = new List<string>() { "madera rustico", "madera oscuro", "madera clara", "madera gris", "alfombre girs con morado", "baldosas con diseno" };
    List<string> posiciones = new List<string>() { "superior izq", "superior der", "centro", "inferior izq", "inferior der" };

    // Start is called before the first frame update
    void Start()
    {
       ddPiso.AddOptions(pisos);
       ddEscritorio.AddOptions(posiciones);
       ddSilla.AddOptions(posiciones);
        
    }

    // Update is called once per frame
    void Update()
    {

        //dropdown_piso.onValueChanged.AddListener(delegate{DropdownItemSelected(dropdown_piso)});
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Bienvenida");
    }
}
