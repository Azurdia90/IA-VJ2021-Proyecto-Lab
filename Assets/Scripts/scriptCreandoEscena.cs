using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCreandoEscena : MonoBehaviour
{

    public static void setSilla(GameObject obj, int val)
    {
        float x = 0.35f;
        float y = 0.20f;
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

        float x = 0.45f;
        float y = 0.25f;

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
        float x = 0.40f;
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
        
        obj.transform.position += arrPosicion;
        obj.transform.localScale = new Vector3(obj.transform.localScale.x, obj.transform.localScale.y, obj.transform.localScale.z * rotate);
    }
}
