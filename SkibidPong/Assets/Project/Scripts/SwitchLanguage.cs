using Kimicu.YandexGames;
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
#if UNITY_EDITOR
        string lang = "ru";
#endif
#if !UNITY_EDITOR
             string lang = YandexGamesSdk.Environment.i18n.lang;
#endif
        if (lang == "ru")
        {
            gameName.text = "Скул бой Пинг-Понг";
            gameInfo.text = "Отбивайте домашку , забей 5 голов и победи!";
            blueWin.text = "Уроков не будет!";
            redWin.text = "Иди делать уроки!";
            if (Device.IsMobile == false)
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

        if (lang == "tr")
        {
            gameName.text = "School Boy Ping-Pong";
            gameInfo.text = "Ödevini yen, 5 gol at ve kazan!";
            blueWin.text = "Ders olmayacak!";
            redWin.text = "Git ödevini yap!";
            if (Device.IsMobile == false)
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

        if (lang == "en")
        {
            gameName.text = "School Boy Ping Pong";
            gameInfo.text = "Beat your homework, score 5 goals and win!";
            blueWin.text = "There will be no lessons!";
            redWin.text = "Go do your homework!";
            if (Device.IsMobile == false)
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