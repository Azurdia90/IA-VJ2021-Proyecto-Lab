using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//mover entre escenas
using UnityEngine.SceneManagement;

public class scriptCrearEspacios : MonoBehaviour
{
    List<string> lista_pisos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var d = serializedObject.FindProperty("DdwnPiso");
        var dropdown_piso = transform.GetComponent<Dropdown>();
        dropdown_piso.options.Clear();
        lista_pisos = new List<string>();
        lista_pisos.Add("piso1_scaled");
        lista_pisos.Add("piso2_scaled");
        lista_pisos.Add("piso3_scaled");

        foreach(var piso in lista_pisos)
        {
            dropdown_piso.options.Add(new Dropdown.OptionData(){text = piso});
        }

        //dropdown_piso.onValueChanged.AddListener(delegate{DropdownItemSelected(dropdown_piso)});
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Bienvenida");
    }
}
