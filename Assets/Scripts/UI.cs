using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private ScoreHandler scoreHandler;

    void Update()
    {
        scoreText.text = "Total Bonks: " + scoreHandler.GetTotalBonks();
    }
}
