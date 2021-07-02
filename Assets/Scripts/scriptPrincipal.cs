using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class scriptPrincipal : MonoBehaviour
{
    public Dropdown ddpiso;
    //public List<SceneModel> sceneList = new List<SceneModel>();
    //List<string> pisos = new List<string>() { "piso2_scaled", "piso2_scaled", "piso2_scaled"};
    private static scriptPrincipal _instance;

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
}
