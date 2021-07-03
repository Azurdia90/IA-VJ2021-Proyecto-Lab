using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptObjetos : MonoBehaviour
{
    //public TMP_Text txtUsuario;
    public GameObject mesa;
    public GameObject silla;
    public GameObject cuadro;
    public Light iluminacion;
    public Light directionalLight;

    public GameObject pisos;

    public Material piso0;
    public Material piso1;
    public Material piso2;

    void Start()
    {
        Debug.Log("Creaci�n de elemento:" + "\n");
        var instancia = scriptPrincipal.GetInstance();
        var escenaActual = instancia.GetCurrentSceneConfig();
        //txtUsuario.text = escenaActual.name;

        Material[] lstPisos = new Material[] { piso0, piso1, piso2 };
        construccionNivel(escenaActual, lstPisos);

        // if(iluminacion != null)
        // {
        //     directionalLight= iluminacion.GetComponent<Light>();
        // }
    }

    void construccionNivel(scriptPrincipal.Escena espacio, Material[] lstPisos)
    {
        Debug.Log("Posicionando silla: " + espacio.silla + "\n");
        scriptCreandoEscena.setSilla(silla, espacio.silla);

        Debug.Log("Posicionando mesa: " + espacio.mesa + "\n");
        scriptCreandoEscena.setMesa(mesa, espacio.mesa);

        Debug.Log("Posicionando cuadro: " + espacio.cuadro + "\n");
        scriptCreandoEscena.setCuadro(cuadro, espacio.cuadro);


        Debug.Log("Posicionando iluminacion" + espacio.iluminacion + "\n");
        scriptCreandoEscena.setIluminacion(iluminacion, espacio.iluminacion);

        Debug.Log("Piso : " + espacio.indexPiso + "\n");        
        Material material = lstPisos[espacio.indexPiso];
        pisos.GetComponent<MeshRenderer>().material = material;

    }
}
