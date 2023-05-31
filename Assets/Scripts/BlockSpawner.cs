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

    private bool spawnToggle = false;

    [SerializeField] float edgeOffset = 10f;
    [SerializeField] float blockLifetime = 30f;
    
    //DEBUG VAR
    private int spawnedBlockCount = 0;
    private int numberOfSpawns = 0;
    // Start is called before the first frame update
    void Start()
    {
        InitialiseBounds();
        InvokeRepeating("SpawnBlocks", 5, 5);
        // StartCoroutine(SpawnBlocks(5));
    }

    // Update is called once per frame
    void Update()
    {
        // if(Mathf.Floor(Time.time) % 2 == 1 && !spawnToggle){
        //     spawnToggle = true;
        //     StartCoroutine(SpawnBlocks(5));
        // }
    }

    private void InitialiseBounds(){
        xMinBound = groundPlane.transform.TransformPoint(-5, 0 , 0).x;
        xMaxBound = groundPlane.transform.TransformPoint(5, 0, 0).x;
        zMinBound = groundPlane.transform.TransformPoint(0, 0, -5).z;
        zMaxBound = groundPlane.transform.TransformPoint(0, 0, 5).z;        
    }

    // private IEnumerator SpawnBlocks(int spawnCount){      
        
    //         for (int i = 0; i < spawnCount; i++)
    //         {
    //                 float spawnX = Random.Range(xMinBound + edgeOffset, xMaxBound - edgeOffset);
    //                 float spawnZ = Random.Range(zMinBound + edgeOffset, zMaxBound - edgeOffset);
    //                 float spawnY = Random.Range(15,50);
    //                 GameObject block = Instantiate(blockPrefab, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity, transform);
    //                 //Debug
    //                 spawnedBlockCount++;
    //                 Destroy(block, blockLifetime);
    //         }
    //         //Debug
    //         numberOfSpawns++;

    //     yield return new WaitForSecondsRealtime(1f);
    //     spawnToggle = false;
    //     Debug.Log("SpawnCompleted: " + numberOfSpawns + " " + " Total Blocks: " + spawnedBlockCount + "    Seconds Passed:" + Mathf.Floor(Time.time));
    // }

    private void SpawnBlocks() {

        int spawnCount = (int)Random.Range(3, 10);
            for (int i = 0; i < spawnCount; i++)
            {
                    float spawnX = Random.Range(xMinBound + edgeOffset, xMaxBound - edgeOffset);
                    float spawnZ = Random.Range(zMinBound + edgeOffset, zMaxBound - edgeOffset);
                    float spawnY = Random.Range(15,50);
                    GameObject block = Instantiate(blockPrefab, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity, transform);
                    Destroy(block, blockLifetime);
            }
    }
}
