using System;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TMP_Text BluePlayerScore;
    [SerializeField] private TMP_Text RedPlayerScore;

    private void Update()
    {
        BluePlayerScore.text = Convert.ToString(scoreManager.BluePlayerScore);
        RedPlayerScore.text = Convert.ToString(scoreManager.RedPlayerScore);
    }
}