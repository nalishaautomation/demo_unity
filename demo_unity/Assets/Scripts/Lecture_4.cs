using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lecture_4 : MonoBehaviour
{
    //public GameObject target;

    public Vehicle myVehicle2;
    // Start is called before the first frame update
    void Start()
    {
        /*
                Vehicle myveh = new Vehicle();

                myveh.speed = 11;
                myveh.color = "Red";

                myveh.VehicleSpeed();*/

        myVehicle2.printParams();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target.transform);     // move with cube or sphere. all axis
        
        //only move x and z axis of cube while moving sphere not y axis
        //Vector3 newPos = new Vector3(target.transform.position.x, transform.position.y,target.transform.position.z);
        //transform.LookAt(newPos);     // move with cube or sphere.

        if (Input.GetMouseButtonDown(0))
        {
            restartLevel();
        }
    }

    void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
