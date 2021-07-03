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


    public class Escena
    {
        public string name;
        public int silla;
        public int mesa;
        public int lampara;
        public int cuadro;
        public int indexPiso;

    }


    // Start is called before the first frame update
    public static scriptPrincipal GetInstance()
    {
        if (_instance == null)
        {
            _instance = new scriptPrincipal();
        }
        return _instance;
    }

    public void crearEscena()
    {
        //currentScene = new Escena(unit);
        //lista_escenas.Add(currentScene);
        //unit = unit -1;
    }
}
