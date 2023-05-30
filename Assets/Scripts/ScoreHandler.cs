using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
  private int totalBonks = 0;

  public void IncrementTotalBonks(){
    totalBonks ++;
  }
  public int GetTotalBonks(){
    return totalBonks;
  }
}
