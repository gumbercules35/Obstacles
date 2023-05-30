using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private MeshRenderer wallRenderer;
    private Color initialMaterialColor;
    private ScoreHandler scoreHandler;

    private int bonkCounter = 0;

    private void Start() {
        scoreHandler = FindObjectOfType<ScoreHandler>();
        wallRenderer = GetComponent<MeshRenderer>();
        initialMaterialColor = wallRenderer.material.color;
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player"){
            if(wallRenderer.material.color == initialMaterialColor){
                wallRenderer.material.color = Color.red;
            }else {
                wallRenderer.material.color = initialMaterialColor;
            }
            bonkCounter++;
            scoreHandler.IncrementTotalBonks();
        }
    }
}
