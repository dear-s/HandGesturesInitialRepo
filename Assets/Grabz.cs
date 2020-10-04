using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabz : MonoBehaviour
{
    // float throwForce = 600;
    // Vector3 objectPos;
    // float distance;

    // public bool canHold = true;
    // public GameObject item;
    // public GameObject tempParent;
    // public bool isHolding = false;

    // void Update(){
    //     if (isHolding == true){
    //         item.GetComponent<Rigidbody>().velocity = Vector3.zero;
    //         item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    //         item.transform.SetParent(temoParent.transform);


    //         if (input.GetMouseButtonDown(1)){
    //             // throw
    //         }

    //         else{
    //             objectPos = item.transform.position;
    //             item.transform.setParent(null);
    //             item.GetComponent<Rigidbody>().useGravity = true;
    //             item.tranform.position = objectPos;
    //         }
    //     }
    // }

    // void onMouseDown(){
    //     isHolding = true;
    //     item.GetComponent<Rigidbody>().useGravity = false;
    //     item.GetComponent<RigidBody>().detectCollisions = true;
        
    // }

    // void onMouseUp(){

    //     isHolding = false;
    // }


    public Transform theDest;

    public GameObject item;

    public GameObject tempParent;

    public float distance;


    void Update() {
        distance=Vector3.Distance(item.transform.position,tempParent.transform.position);
    }

    void OnMouseDown()
    {
        if (distance <= 3f){
            GetComponent<SphereCollider>().enabled = false;
            // turn off gravity
            GetComponent<Rigidbody>().useGravity = false;
            // GetComponent<Rigidbody>.freezeRotation = true;

            // change the transform psoition - move it
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("theDest").transform;
        }
        
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        // getComponent<Rigidbody>().freezeRotation = false;
        
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<SphereCollider>().enabled = true;
    }
}
