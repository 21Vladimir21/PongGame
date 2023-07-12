using UnityEngine;
using TMPro;

public class SwitchLanguage : MonoBehaviour
{
    [SerializeField] private TMP_Text gameName;
    [SerializeField] private TMP_Text gameInfo;
    [SerializeField] private TMP_Text blueHelpInfo;
    [SerializeField] private TMP_Text redHelpInfo;
    [SerializeField] private TMP_Text blueWin;
    [SerializeField] private TMP_Text redWin;

    private void Start()
    {
        if (Init.Instance.language == "ru")
        {
            gameName.text = "Пинг Понг";
            gameInfo.text = "Отбивайте мячи, забивайте голы.Наберите 5 очков для победы";
            blueWin.text = "Синий победил!";
            redWin.text = "Красный победил!";
            if (Init.Instance.mobile == false)
            {
                blueHelpInfo.text = "Нажимай Z";
                redHelpInfo.text = "Нажимай M";
            }
            else
            {
                blueHelpInfo.text = "Клик";
                redHelpInfo.text = "Клик";
            }
        }
        if (Init.Instance.language == "tr")
        {
            gameName.text = "Ping Pong";
            gameInfo.text = "Topları savuşturun, gol atın.Kazanmak için 5 puan toplayın";
            blueWin.text = "Mavi kazandı!";
            redWin.text = "Kızıl kazandı!";
            if (Init.Instance.mobile == false)
            {
                blueHelpInfo.text = "Bas Z";
                redHelpInfo.text = "Bas M";
            }
            else
            {
                blueHelpInfo.text = "Tıkla";
                redHelpInfo.text = "Tıkla";
            }
        }
        if (Init.Instance.language == "en")
        {
            gameName.text = "Ping Pong";
            gameInfo.text = "Hit the balls, score goals.Collect 5 points to win";
            blueWin.text = "Blue has won!";
            redWin.text = "Red has won!";
            if (Init.Instance.mobile == false)
            {
                blueHelpInfo.text = "Push Z";
                redHelpInfo.text = "Push M";
            }
            else
            {
                blueHelpInfo.text = "Click";
                redHelpInfo.text = "Click";
            }
        }
    }
}
