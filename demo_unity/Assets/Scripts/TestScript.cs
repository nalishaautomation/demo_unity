using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestScript : MonoBehaviour
{
    public int pranav = 5;

    public int[] list;

    public GameObject[] Newobject;

    public Color[] NewColors;

    GameObject[] objAll;

    GameObject findSphere;

    Rigidbody rbNew;
    // Start is called before the first frame update
    void Start()
    {
        // print(list[1]);

        //Destroy(Newobject[2]);
        /* int i = 0;
         while (i < 5)
         {

             for (int j = 0; j < 3; j++)
             {
                 Newobject[1].GetComponent<Renderer>().material.color = NewColors[j + 1 ];
                 Newobject[0].GetComponent<Renderer>().material.color = NewColors[j + 2];
                 Newobject[2].GetComponent<Renderer>().material.color = NewColors[j + 3 ];
             }
             i++;
         }*/
        /*
                foreach(GameObject go in Newobject)
                {
                    //Destroy(go);
                    go.SetActive(false);
                }*/

        //findSphere = GameObject.Find("Sphere/Sphere/Sphere");
        //findSphere = GameObject.FindWithTag("Destroy");
        /*
                objAll = GameObject.FindGameObjectsWithTag("Destroy");

                foreach(GameObject obj in objAll)
                {
                    Destroy(obj);
                }
                */

        rbNew = GetComponent<Rigidbody>();
        rbNew.useGravity = true;
        /*rbNew.mass = 5;

        TotalScore totalScore;
        totalScore = GetComponent<TotalScore>();        // for getting the porperties value from another script
        totalScore.score = 100;*/

        GameObject.Find("Cylinder").GetComponent<TotalScore>().score = 500;

        GameObject.Find("Cylinder").GetComponent<Rigidbody>().useGravity = true; 
    }


    // Update is called once per frame
    void Update()
    {
        
        //print("Hi Pranav");
    }
}
