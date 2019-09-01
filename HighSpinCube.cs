using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighSpinCube : MonoBehaviour
{
    public GameObject myPrefab;

    void Start()
    {

        int totalCubes = 50;

        float totalDistance = 2.9f; //How close cubes get to the wall. 

        //SIN() DISTRIBUTION
        for (int j = 0; j < 5; j++)
        {


            for (int i = 0; i < totalCubes; i++)
            {

                float perc = i / (float)totalCubes;

                float sin = Mathf.Sin(perc * Mathf.PI / 2);

                float x = 1.8f + sin * totalDistance; //Distance to the main square. 
                float y = 2.0f + (1 * i);
                float z = 0.0f;

                //Easiest way to establish instantiate prefabs
                var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity); //Quarterrnion identity means just he default rotation. Instantiate returns an object so casting it as a game object. 
                newCube.GetComponent<CubeCode>().setSize(.5f * (1.0f - perc)); //Accesing Publice Function in CubeScript // Dampening the size by .5
                newCube.GetComponent<CubeCode>().rotateSpeed = .8f + perc * 6.0f; // Adding .2 so the initial instance of a cubes speed is not zero. 

            }

        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
