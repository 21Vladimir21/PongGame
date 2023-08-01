using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] Transform ballPosition;

    [SerializeField] private GameObject PingPong;
    [SerializeField] private GameObject PingPongPanel;
    [SerializeField] private GameObject BlueWinPanel;
    [SerializeField] private GameObject RedWinPanel;
    [SerializeField] private GameObject PongUi;
    [SerializeField] private GameObject HelpInfoAi;

    private int numberOfGames = 0;

    public bool EnemyAi = false;


    public static UnityEvent WhoWon = new UnityEvent();
    private void Awake()
    {
        WhoWon.AddListener(WhoWonPong);
    }

    private void WhoWonPong()
    {
        if (scoreManager.BluePlayerScore >= 5)
            StartCoroutine(WinScrens(true));

        if (scoreManager.RedPlayerScore >= 5)

            StartCoroutine(WinScrens(false));
    }
    public void ResetScore()
    {
        scoreManager.BluePlayerScore = 0;
        scoreManager.RedPlayerScore = 0;
    }
    private IEnumerator WinScrens(bool blueWin)
    {
        if (!blueWin)
            RedWinPanel.SetActive(true);
        if (blueWin)
            BlueWinPanel.SetActive(true);

        yield return new WaitForSeconds(3);
        numberOfGames++;
        ResetScore();
        BackToMenu();
    }

    public void BackToMenu()
    {
        if (numberOfGames == 3)
            Init.Instance.RateGameFunc();
        if (numberOfGames != 3)
            Init.Instance.ShowInterstitialAd();

        ResetScore();
        PingPong.SetActive(false);
        PingPongPanel.SetActive(true);
        RedWinPanel.SetActive(false);
        BlueWinPanel.SetActive(false);
        PongUi.SetActive(false);
        UI.RefreshScore.Invoke(scoreManager.BluePlayerScore, scoreManager.RedPlayerScore);
        ballPosition.position = Vector2.zero;
    }
    public void PlayButton(bool enemyAi)
    {
        if (enemyAi)
            HelpInfoAi.SetActive(false);
        else
            HelpInfoAi.SetActive(true);

        EnemyAi = enemyAi;
        PingPongPanel.SetActive(false);
        PingPong.SetActive(true);
        PongUi.SetActive(true);
    }
}
