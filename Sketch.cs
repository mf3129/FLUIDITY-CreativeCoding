using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour
{

    public GameObject myPrefab; 

    void Start(){

        int totalCubes = 12; 

        float totalDistance = 2.9f; //How close cubes get to the wall. 

        //SIN() DISTRIBUTION
        for (int i = 0; i < totalCubes; i++) {
            
            float perc = i /(float)totalCubes; 

            float sin = Mathf.Sin(perc * Mathf.PI/2);  

            float x = 1.8f + sin * totalDistance; //Distance to the main square. 
            float y = 5.0f; 
            float z = 0.0f; 

            //Easiest way to establish instantiate prefabs
            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity); //Quarterrnion identity means just he default rotation. Instantiate returns an object so casting it as a game object. 
            newCube.GetComponent<CubeScript>().setSize(.5f * (1.0f - perc) ); //Accesing Publice Function in CubeScript // Dampening the size by .5
            newCube.GetComponent<CubeScript>().rotateSpeed = .2f + perc * 4.0f; // Adding .2 so the initial instance of a cubes speed is not zero. 

        }

    }


    void Update()
    {
        
    }
}




/* 
        //Linear DISTRO
        for (int i = 0; i < totalCubes; i++) {
            
            float perc = i /(float)totalCubes; 

            float x = perc * totalDistance; 
            float y = 3.0f; 
            float z = 0.0f; 

            //Easiest way to establish instantiate prefabs
            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity); //Quarterrnion identity means just he default rotation. Instantiate returns an object so casting it as a game object. 
            newCube.GetComponent<CubeScript>().setSize(1.0f - perc); //Accesing Publice Function in CubeScript
            newCube.GetComponent<CubeScript>().rotateSpeed = 0; // Random.value perc

        }
*/