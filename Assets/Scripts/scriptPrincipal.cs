using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    private static int unit = 0;
    private static List<Escena> lista_escenas = new List<Escena>();

//  Objetos para el manejo de las escenas
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    //Para el objecto que muestra la imagen
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;

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
    public void AddLogText(string txt)
    {
        string path = Application.dataPath + "/bitacora_201020331_201314697.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "**** LOGS ****\n");
        }
        string content = $"** Logging date: {System.DateTime.Now} **\n{txt}\n\n";
        File.AppendAllText(path, content);
    }

    public Escena GetCurrentSceneConfig()
    {
        if (currentScene == null) {
            unit = 3;
            currentScene = lista_escenas[3];
        }
        return currentScene;
    }

    public void setListaEspacios(Dropdown lista)
    {
        List<string> lista_nombres = new List<string>();
        for(int i = 0; i < lista_escenas.Count; i++)
        {
            lista_nombres.Add(lista_escenas[i].name);
        }
        lista.AddOptions(lista_nombres);
    }


    public void crearEscena(int piso, int iluminacion, int mesa, int silla, int cuadro, int indexpiso)
    {
        if(lista_escenas.Count < 3)
        {
            unit = unit + 1;
            if(mesa != silla)
            {
                currentScene = new Escena(unit,piso,iluminacion,mesa,silla,cuadro);
                lista_escenas.Add(currentScene);
                AddLogText($"Se creo el espacio ${unit + 1}");
                #if UNITY_EDITOR
                    EditorUtility.DisplayDialog("Alerta","El espacio ha sido creado.", "", "");
                #endif
            }
            else
            {
                AddLogText($"Error: Se intento colocar l Siila y la mesa en la misma posición");
                #if UNITY_EDITOR
                    EditorUtility.DisplayDialog("Alerta","Silla y Mesa no pueden estar en la misma posición.", "", "");
                #endif
            }
        }
        else
        {
            AddLogText($"Error: Los tres espacios ya han sido utilizados");
            #if UNITY_EDITOR
            EditorUtility.DisplayDialog("Alerta", "Los 3 espacios ya fueron utilizados.", "", "");
            #endif
        }
        
    }

    public void verEscena(int index)
    { 
        if(lista_escenas.Count > 0)
        {
            if(lista_escenas[index] == null)
            {
                AddLogText($"No se podra ver el espacio ${index + 1}");
                #if UNITY_EDITOR
                    EditorUtility.DisplayDialog("Alerta","No se puede ver el espacio {index + 1}, aún no ha sido definido.", "", "");
                #endif
            }
            else
            {   
                cambiarImagenVerEspacio(index);
                LoadScene("Habitacion1", index);
            }
        }
        else
        {
            #if UNITY_EDITOR
            EditorUtility.DisplayDialog("Alerta", "No hay espacios disponibles para mostrar.", "", "");
            #endif
        }
    }

    public bool existeEspacioNumero(int numero)
    {
        return lista_escenas[numero] != null;
    }
    public void eliminarEscena(int index)
    {
        if(lista_escenas.Count > 0)
        {
            unit = unit -1;
            lista_escenas.RemoveAt(index); 
            AddLogText($"Se elimin� el espacio ${index + 1}");
        }
        else
        {
            AddLogText($"Error: Los 3 espacios fueron eliminados");
            #if UNITY_EDITOR
            EditorUtility.DisplayDialog("Alerta", "Los 3 espacios fueron eliminados.", "", "");
            #endif
        }
    }
    public void cambiarImagenVerEspacio(int index)
    {
        if(gameObject2 != null)
        {
            #if UNITY_EDITOR
                gameObject2.GetComponent<Image>().sprite = getSprite(index);
            #endif
        }
    }

    private Sprite getSprite(int index)
    {
        Escena s= lista_escenas[index];
        if (s == null) return sprite1;
        switch (s.indexPiso)
        {
            case 0:
                return sprite1;
            case 1:
                return sprite2;
            case 2:
                return sprite3;
            default:
                return sprite1;
        }
    }

    public void LoadScene(string sceneName, int index)
    {
        if (index < 0) 
        {
            AddLogText($"No fue posible visualizar el espacio ${index + 1}");
            #if UNITY_EDITOR
                EditorUtility.DisplayDialog("Alerta", "Ocurrio un error no fue encontrada el Espacio.", "", "");
            #endif
            return;
        }

        currentScene = lista_escenas[index];
        AddLogText($"Se podra visualizar el espacio ${index + 1}");
        Application.LoadLevel(sceneName);
    }

    public class Escena
    {
        public string name;
        public int piso;
        public int iluminacion;
        public int mesa;
        public int silla;
        public int cuadro;
        public int indexPiso;

        public Escena(int nivel, int ppiso, int piluminacion, int pmesa, int psilla, int pcuadro)
        {
            this.name = "Escena " + nivel;
            this.piso = ppiso;
            this.iluminacion = piluminacion;
            this.mesa = pmesa;
            this.silla = psilla;
            this.cuadro = pcuadro;
            this.indexPiso = ppiso;
        }

    }
}
