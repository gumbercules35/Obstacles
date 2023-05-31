using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private float spinRate = 90f;
    private Vector3 eulerRotate;
    // Start is called before the first frame update
    void Start()
    {
        eulerRotate = new Vector3(spinRate, 0f, 0f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(eulerRotate);
    }
}
