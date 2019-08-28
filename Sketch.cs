using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour
{

    public GameObject myPrefab; 

    void Start(){

        int totalCubes = 8; 

        int totalDistance = 5; 

        for (int i = 0; i < totalCubes; i++) {
            
            float perc = i /(float)totalCubes; 

            float x = perc * totalDistance; 
            float y = 5.0f; 
            float z = 0.0f; 

            //Easiest way to establish instantiate prefabs
            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity); //Quarterrnion identity means just he default rotation. Instantiate returns an object so casting it as a game object. 
            newCube.GetComponent<CubeScript>().setSize(1.0f - perc); //Accesing Publice Function in CubeScript
            newCube.GetComponent<CubeScript>().rotateSpeed = perc; // Random.value

        }

    }


    void Update()
    {
        
    }
}
