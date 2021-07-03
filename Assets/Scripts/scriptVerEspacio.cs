using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//mover entre escenas
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class scriptVerEspacio : MonoBehaviour
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

    public void verEspacio()
    {
        scriptPrincipal.GetInstance().verEscena(ddespacios.value);   
    }
}
