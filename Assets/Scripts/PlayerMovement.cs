using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 rawInput;
    private Rigidbody playerRigidBody;
    private float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayerByInput();
    }

    private void OnMove(InputValue value){
        rawInput = value.Get<Vector2>();
    }

    private void MovePlayerByInput(){
        transform.Translate(new Vector3(rawInput.x, 0f, rawInput.y) * moveSpeed * Time.deltaTime);
    }
}
