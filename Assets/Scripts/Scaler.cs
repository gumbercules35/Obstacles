using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomScale = Random.Range(2, 5);
        transform.localScale = new Vector3(randomScale, randomScale, randomScale); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
