using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{

    /// <summary>
    /// Switch between screens
    /// </summary>
    // Start is called before the first frame update

    public int sceneNumber;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Loadlevel();    
        }
        
    }

    void Loadlevel()
    {
        SceneManager.LoadScene(sceneNumber); //SceneManager.LoadScene("level2");
    }
}
