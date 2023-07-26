using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timeStart = 3;
    [SerializeField] TMP_Text timertext;
    private bool timerRunnong = true;
    public bool Complited;

    private void OnEnable()
    {
        Complited = false;
        timeStart = 3;
        timertext.text = timeStart.ToString();
        Update();
    }

    void Update()
    {
        if (timerRunnong == true)
        {
            timeStart -= Time.deltaTime;
            timertext.text = Mathf.Round(timeStart).ToString();

            if (timeStart < 0)
            {
                timeStart = 0;
                Complited = true;
                gameObject.SetActive(false);
            }

        }
    }
}
