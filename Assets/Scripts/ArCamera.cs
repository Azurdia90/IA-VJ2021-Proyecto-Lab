using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class ArCamera : MonoBehaviour
{
    public GameObject espacio1;
    public GameObject espacio2;
    public GameObject espacio3;
    
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


    private void activadDesactivar(){
          var instance = scriptPrincipal.GetInstance();
        
        if (instance.existeEspacioNumero(0)){
            espacio1.SetActive(true);
             Debug.Log("Existe escena 1...");
        }else{
            espacio1.SetActive(false);
        }
        
        if (instance.existeEspacioNumero(1)){
            espacio2.SetActive(true);  
             Debug.Log("Existe escena 2...");
        }else{
            espacio2.SetActive(false);
        }
       
        if (instance.existeEspacioNumero(2)){
            espacio3.SetActive(true);  
             Debug.Log("Existe escena 3...");
        }else{
            espacio3.SetActive(false);
        }
    
    }

}