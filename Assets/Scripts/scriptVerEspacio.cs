using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mover entre escenas
using UnityEngine.SceneManagement;

public class scriptVerEspacio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        
    }
}
