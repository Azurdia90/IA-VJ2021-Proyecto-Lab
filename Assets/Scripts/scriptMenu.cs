using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//mover entre escenas
using UnityEngine.SceneManagement;

public class scriptMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CrearEscena()
    {
        SceneManager.LoadScene("CrearEspacio");
    }

    public void VerEscena()
    {
        SceneManager.LoadScene("VerEscena");
    }

    public void EliminarEscena()
    {
        SceneManager.LoadScene("EliminarEspacios");
    }
}
