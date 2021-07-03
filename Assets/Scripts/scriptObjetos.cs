using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptObjetos : MonoBehaviour
{
    public TMP_Text txtUsuario;
    public GameObject mesa;
    public GameObject silla;
    public GameObject cuadro;

    public GameObject pisos;

    public Material piso0;
    public Material piso1;
    public Material piso2;

    void Start()
    {
        Debug.Log("Creación de elemento:" + "\n");
        var instancia = Principal.GetInstance();
        var escenaActual = instancia.GetCurrentSceneConfig();
        txtUsuario.text = escenaActual.name;

        Material[] lstPisos = new Material[] { piso0, piso1, piso2, piso3, piso4, piso5 };
        construccionNivel(escenaActual, lstPisos);
    }


    void construccionNivel(Principal.SceneModel espacio, Material[] lstPisos)
    {
        Debug.Log("Posicionando silla: " + espacio.silla + "\n");
        createEscena.setSilla(silla, espacio.silla);

        Debug.Log("Posicionando mesa: " + espacio.mesa + "\n");
        createEscena.setMesa(mesa, espacio.mesa);

        Debug.Log("Posicionando cuadro: " + espacio.cuadro + "\n");
        createEscena.setSofa(sofa, espacio.cuadro);

        Debug.Log("Piso : " + espacio.indexPiso + "\n");        
        Material material = lstPisos[espacio.indexPiso];
        pisos.GetComponent<MeshRenderer>().material = material;

    }


}
