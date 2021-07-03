using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//mover entre escenas
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class scriptEliminarEpacio : MonoBehaviour
{
    public Dropdown ddespacios; 
    // Start is called before the first frame update
    void Start()
    {
        if(ddespacios != null)
        {
            scriptPrincipal.GetInstance().setListaEspacios(ddespacios);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Regresar()
    {
        SceneManager.LoadScene("Bienvenida");
    }

    public void EliminarEspacio()
    {
        scriptPrincipal.GetInstance().eliminarEscena(ddespacios.value);
        SceneManager.LoadScene("EliminarEspacios");
    }
}
