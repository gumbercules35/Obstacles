using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
  private int totalBonks = 0;

  private void Awake() {
    int scoreHandlerCount = FindObjectsOfType<ScoreHandler>().Length;
    if (scoreHandlerCount > 1){
        Destroy(gameObject);
    } else {
        DontDestroyOnLoad(gameObject);
    }
  }
  public void IncrementTotalBonks(){
    totalBonks ++;
  }
  public int GetTotalBonks(){
    return totalBonks;
  }
}
