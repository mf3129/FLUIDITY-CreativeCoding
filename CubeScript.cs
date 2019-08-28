using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{   

    public float rotateSpeed = 1.0f; 
    public Vector3 spinSpeed = new Vector3(0, 0, 0);     // public Vector3 spinSpeeds = new Vector3.zero();  //  A shortcut to set all xyz variables in vector to 0
    Vector3 spinAxis = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {

        //We are going to procedurally set the original position of the cube
        // this.transform.position = new Vector3(0, 5, 3); //Creating a collection of 3 values
        spinSpeed = new Vector3(Random.value, Random.value, Random.value);  //Random Value gives a value from 0.0 to 1.0; 

        spinAxis = Vector3.up; 
        spinAxis.x = (Random.value - Random.value) * .1f; // 0 -1 = -1 // 1 - 0 = + 1 Picking number from -1 to 1 | This dampens the spin on the axis


    }

    //Creating Function to set the size
    
    public void setSize(float size) {
        this.transform.localScale = new Vector3(size, size, size); 
    }


    // Update is called once per frame
    void Update(){
        
        //Will Rotate aorund itself
        this.transform.Rotate(spinSpeed); //Could have done it the Vector3 as well

        //Will Rotate arund axis point in the room
        this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed); 

    }
}
