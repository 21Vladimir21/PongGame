using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;

    [SerializeField] private GameObject PingPong;
    [SerializeField] private GameObject PingPongPanel;
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject BlueWinPanel;
    [SerializeField] private GameObject RedWinPanel;


    public bool TwoPlayers = false;

    void Update()
    {
        WhoWonPong();
    }

    private void WhoWonPong()
    {
        if (scoreManager.BluePlayerScore == 5)
        {
            StartCoroutine(BlueWin());
            ResetScore();
        }
        if (scoreManager.RedPlayerScore == 5)
        {
            StartCoroutine(RedWin());
            ResetScore();
        }
    }
    public void ResetScore()
    {
        scoreManager.BluePlayerScore = 0;
        scoreManager.RedPlayerScore = 0;
    }

    public void StartPongGame()
    {
        PingPongPanel.SetActive(true);
        Menu.SetActive(false);
    }

    private IEnumerator BlueWin()
    {
        BlueWinPanel.SetActive(true);
        yield return new WaitForSeconds(3);
        BackToMenu();
    }
    private IEnumerator RedWin()
    {
        RedWinPanel.SetActive(true);
        yield return new WaitForSeconds(3);
        BackToMenu();
    }
    public void BackToMenu()
    {
        RedWinPanel.SetActive(false);
        BlueWinPanel.SetActive(false);
        PingPong.SetActive(false);
        PingPongPanel.SetActive(false);
        Menu.SetActive(true);
    }
    public void PlayingWithOnePlayer()
    {
        TwoPlayers = false;
        PingPongPanel.SetActive(false);
        PingPong.SetActive(true);
    }
    public void PlayingWithTwoPlayer()
    {
        TwoPlayers = true;
        PingPongPanel.SetActive(false);
        PingPong.SetActive(true);
    }
}
