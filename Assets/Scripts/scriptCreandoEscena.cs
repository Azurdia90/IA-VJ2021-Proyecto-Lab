using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class scriptCreandoEscena : MonoBehaviour
{

    public static void setSilla(GameObject obj, int val)
    {
        float x = 0.30f;
        float y = 0.30f;
        int rotate = 1;

        Vector3 arrPosicion;

        if (val == 0)
        { 
            arrPosicion = new Vector3(-x, 0, y);
        }
        else if (val == 1)
        {
            arrPosicion = new Vector3(x, 0, y);
        }
        else if (val == 2)
        {
            arrPosicion = new Vector3(0, 0, 0);
        }
        else if (val == 3)
        {
            rotate = -1;
            arrPosicion = new Vector3(-x, 0, -y);

        }
        else if (val == 4)
        {
            rotate = -1;
            arrPosicion = new Vector3(x, 0, -y);

        }
        else
        {
            arrPosicion = new Vector3(0, 0, 0);
        }

        obj.transform.position += arrPosicion;
        obj.transform.localScale = new Vector3(obj.transform.localScale.x, obj.transform.localScale.y, obj.transform.localScale.z * rotate);
    }

    public static void setMesa(GameObject obj, int val)
    {
        float x = 0.30f;
        float y = 0.30f;

        Vector3 arrPosicion;

        if (val == 0)
        {
            arrPosicion = new Vector3(-x, 0, y);
        }
        else if (val == 1)
        {
            arrPosicion = new Vector3(x, 0, y);
        }
        else if (val == 2)
        {
            arrPosicion = new Vector3(0, 0, 0);
        }
        else if (val == 3)
        {
            arrPosicion = new Vector3(-x, 0, -y);

        }
        else if (val == 4)
        {
            arrPosicion = new Vector3(x, 0, -y);

        }
        else
        {
            arrPosicion = new Vector3(0, 0, 0);
        }

        obj.transform.position += arrPosicion;

    }
    
    public static void setCuadro(GameObject obj, int val)
    {
        float x = 0.30f;
        float y = 0.30f;
        int rotate = 1;

        Vector3 arrPosicion;

        if (val == 0)
        {
            arrPosicion = new Vector3(0,0.50f, 0.35f);
        }
        else if (val == 1)
        {
            arrPosicion = new Vector3(0.45f,0.5f,0);
        }
        else
        {
            arrPosicion = new Vector3(0, 0, 0);
        }

        obj.transform.position += arrPosicion;
        obj.transform.localScale = new Vector3(obj.transform.localScale.x, obj.transform.localScale.y, obj.transform.localScale.z * rotate);
    }
    public static void setIluminacion(Light obj, int val)
    {
        if(obj != null)
        {
            if(val == 0)
            {
                obj.color = Color.green;
            }
            else if(val == 1)
            {
                obj.color = Color.blue;
            }
            else if(val == 2)
            {
                obj.color = Color.red;
            } 
            else
            {
                obj.color = Color.white;
            }
            //obj.color = new Color32(System.Convert.ToByte(Random.Range(0, 255)), System.Convert.ToByte(Random.Range(0, 255)), System.Convert.ToByte(Random.Range(0, 255)), 255);
        }
        else
        {
            #if UNITY_EDITOR
            EditorUtility.DisplayDialog("Alerta", "objeto vacio", "", "");
            #endif
        }

    }
}
