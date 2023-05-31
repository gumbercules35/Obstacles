using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 modifiedInput;
    private float moveSpeed = 5000f;
    private Rigidbody playerRigidBody;
    private ScoreHandler scoreHandler;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        scoreHandler = GetComponent<ScoreHandler>();
        
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayerByInput();
    }

    private void OnMove(InputValue value){
        modifiedInput = value.Get<Vector2>() * moveSpeed;
    }

    private void OnFire(){
        
    }


    private void MovePlayerByInput(){
        // transform.Translate(new Vector3(modifiedInput.x, 0f, modifiedInput.y) * moveSpeed * Time.deltaTime);
        playerRigidBody.velocity = new Vector3(modifiedInput.x, 0f, modifiedInput.y) * Time.deltaTime;
        
    }
}
