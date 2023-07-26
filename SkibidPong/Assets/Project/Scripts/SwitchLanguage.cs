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
            gameName.text = "Cкибиди против Гримаса Пинг-Понг";
            gameInfo.text = "Отбивайте шейк , забей 5 голов и победи!";
            blueWin.text = "Гримас победил!";
            redWin.text = "Туалет победил!";
            if (Init.Instance.mobile == false)
            {
                blueHelpInfo.text = "Нажимай Q";
                redHelpInfo.text = "Нажимай P";
            }
            else
            {
                blueHelpInfo.text = "Клик";
                redHelpInfo.text = "Клик";
            }
        }
        if (Init.Instance.language == "tr")
        {
            gameName.text = "Skibidi vs Yüz Buruşturmacası Ping-Pong";
            gameInfo.text = "Shake'i savunun, 5 gol at ve kazan!";
            blueWin.text = "Yüz buruşturma kazandı!";
            redWin.text = "Tuvalet kazandı!";
            if (Init.Instance.mobile == false)
            {
                blueHelpInfo.text = "Bas Q";
                redHelpInfo.text = "Bas P";
            }
            else
            {
                blueHelpInfo.text = "Tıkla";
                redHelpInfo.text = "Tıkla";
            }
        }
        if (Init.Instance.language == "en")
        {
            gameName.text = "Skibidi vs Grimace Ping Pong";
            gameInfo.text = "Beat the shake, score 5 goals and win!";
            blueWin.text = "Grimace has won!";
            redWin.text = "Toilet has won!";
            if (Init.Instance.mobile == false)
            {
                blueHelpInfo.text = "Push Q";
                redHelpInfo.text = "Push P";
            }
            else
            {
                blueHelpInfo.text = "Click";
                redHelpInfo.text = "Click";
            }
        }
    }
}
