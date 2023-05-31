using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private MeshRenderer wallRenderer;
    private Color initialMaterialColor;
    private ScoreHandler scoreHandler;

    
    private bool hasBonked = false;

    private void Start() {
        scoreHandler = FindObjectOfType<ScoreHandler>();
        wallRenderer = GetComponent<MeshRenderer>();
        initialMaterialColor = wallRenderer.material.color;
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player" && !hasBonked){
            if(wallRenderer.material.color == initialMaterialColor){
                wallRenderer.material.color = Color.red;
                
                switch (gameObject.tag){
                    case "Wall":
                    scoreHandler.IncrementTotalBonks(1);
                    break;
                    case "Block":
                    scoreHandler.IncrementTotalBonks(5);
                    break;
                    case "Spinner":
                    scoreHandler.IncrementTotalBonks(2);
                    break;
                    default:
                    break;
                }
                hasBonked = true;
            }
        }
    }
}
