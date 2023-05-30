using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] GameObject groundPlane;
    [SerializeField] GameObject blockPrefab;
    private float xMinBound;
    private float xMaxBound;
    private float zMinBound;
    private float zMaxBound;

    [SerializeField] float edgeOffset = 10f;
   
    // Start is called before the first frame update
    void Start()
    {
        InitialiseBounds();
        SpawnBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitialiseBounds(){
        xMinBound = groundPlane.transform.TransformPoint(-5, 0 , 0).x;
        xMaxBound = groundPlane.transform.TransformPoint(5, 0, 0).x;
        zMinBound = groundPlane.transform.TransformPoint(0, 0, -5).z;
        zMaxBound = groundPlane.transform.TransformPoint(0, 0, 5).z;        
    }

    private void SpawnBlocks(){      

       for (int i = 0; i < 10; i++)
       {
            float spawnX = Random.Range(xMinBound + edgeOffset, xMaxBound - edgeOffset);
            float spawnZ = Random.Range(zMinBound + edgeOffset, zMaxBound - edgeOffset);
            Instantiate(blockPrefab, new Vector3(spawnX, 10, spawnZ), Quaternion.identity, transform);
       }
    }
}
