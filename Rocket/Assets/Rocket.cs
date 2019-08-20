using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    Rigidbody rbd;

  
    public  int TrustFACTOR = 500;
    public  int RelationFactor = 5000;
    // Use this for initialization
    void Start () {
        rbd = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Jump") != 0)
        {
            rbd.AddRelativeForce(new Vector3(0, Input.GetAxis("Jump")* TrustFACTOR, 0));
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
         
            rbd.AddForceAtPosition(new Vector3(Input.GetAxis("Horizontal")* RelationFactor, 0, 0), new Vector3(0,50, 0) );
        }
    }
}
