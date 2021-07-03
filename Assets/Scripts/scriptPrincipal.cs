using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class scriptPrincipal : MonoBehaviour
{
    //Instacia del Singleton
    private static scriptPrincipal _instance;
    //Objetos para manejo de escenas
    private static Escena currentScene = null;
    private static int unit = 3;
    public static List<Escena> lista_escenas = new List<Escena>();

    // Start is called before the first frame update
    public static scriptPrincipal GetInstance()
    {
        if (_instance == null)
        {
            _instance = new scriptPrincipal();
        }
        return _instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void crearEscena()
    {
        currentScene = Escena(unit);
        lista_escenas.Add(currentScene);
        unit = unit -1;
    }
}
