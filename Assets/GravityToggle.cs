using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityToggle : MonoBehaviour
{
    private Rigidbody blockRigidBody;
    private float startTime;
    private float dropTime;

    private void Awake() {
       blockRigidBody = GetComponent<Rigidbody>();
       startTime = Time.time;
        
    }
    void Start()
    {
       dropTime = Random.Range(3, 10);
       blockRigidBody.useGravity = false;
       blockRigidBody.velocity = new Vector3(0, 0, 0); 
    }

    void Update()
    {
      if (Time.time - startTime > dropTime){
        blockRigidBody.useGravity = true;
      }   
    }
}
