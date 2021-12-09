using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture3 : MonoBehaviour
{
    Vector3 position;

    //float speed = 0.01f;
    public GameObject[] cube;

    // Start is called before the first frame update
    void Start()
    {

        //position = new Vector3(1f,3f,5f);

        //Invoke("randomBall", 5f);

        //InvokeRepeating("randomBall", 3f,1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0, 1f, 0);
        //transform.position += new Vector3(0, 0.001f, 0);
        //transform.position += new Vector3(0, speed, 0);

        //transform.position += transform.forward * speed;
        //transform.Translate(speed,0,0);           // for moving 
        //transform.Rotate(0,0, speed);
        //transform.localScale += new Vector3(speed, 0, 0);           // for sizing 

        /*if (Input.GetMouseButtonDown(0))        // 0-- left ,  1- right , 2- wheel
        {
            //Instantiate(cube, transform.position, Quaternion.identity);       // single object with mouse key

            int randomNumber = Random.Range(0, cube.Length);
            Instantiate(cube[randomNumber], transform.position, Quaternion.identity);
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            //CancelInvoke("randomBall");

            Vector3 pos = Input.mousePosition;
            pos.z = 6f;

            pos = Camera.main.ScreenToWorldPoint(pos);

            int randomNumber = Random.Range(0, cube.Length);
            Instantiate(cube[randomNumber], pos, Quaternion.identity);
        }

        
    }

    void randomBall()
    {
        int randomNumber = Random.Range(0, cube.Length);
        Instantiate(cube[randomNumber], transform.position, Quaternion.identity);
    }
}
