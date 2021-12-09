using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]  
public class Vehicle 
{


    public float speed;
    public string color;

    public void VehicleSpeed()
    {
        Debug.Log(speed);
    }

    public Vehicle()
    {
        Debug.Log("Default Constructor is called");
    }

    public Vehicle(float speedval)
    {
        this.speed = speedval;
    }
    public Vehicle(float spdval, string color)
    {
        this.speed = spdval;
        this.color = color;
    }

    public void printParams()
    {
        Debug.Log("Speed is  " + speed);
        Debug.Log("Color is  " + color);
    }
}
