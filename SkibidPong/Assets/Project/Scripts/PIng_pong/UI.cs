using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text BluePlayerScore;
    [SerializeField] private TMP_Text RedPlayerScore;

    public static UnityEvent<int, int> RefreshScore = new UnityEvent<int, int>();

    private void Awake()
    {
        RefreshScore.AddListener(Score);
    }

    private void Score(int blueScore, int redScore)
    {
        BluePlayerScore.text = Convert.ToString(blueScore);
        RedPlayerScore.text = Convert.ToString(redScore);
    }
}