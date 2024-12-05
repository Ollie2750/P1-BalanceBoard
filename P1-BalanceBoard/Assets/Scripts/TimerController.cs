using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerController : MonoBehaviour
{
    [SerializeField] private float timeCounter;
    [SerializeField] private float CountdownTimer = 120f;
    [SerializeField] private int minutes;
    [SerializeField] private int seconds;
    [SerializeField] private bool isCountdown;
    [SerializeField] private TextMeshProUGUI timerText;

    private void Update()
    {
        if (isCountdown && CountdownTimer > 0)
        {
            CountdownTimer -= Time.deltaTime;
            minutes = Mathf.FloorToInt(CountdownTimer / 60f);
            seconds = Mathf.FloorToInt(CountdownTimer - minutes * 60);
        }
        else if (!isCountdown)
        {
            timeCounter += Time.deltaTime;
            minutes = Mathf.FloorToInt(timeCounter / 60f);
            seconds = Mathf.FloorToInt(timeCounter - minutes * 60);
        }

        
        timerText.text=string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    public void StartCountdown(float duration, System.Action onComplete)
    {
        StartCoroutine(Countdown(duration, onComplete));
    }

    private IEnumerator Countdown(float duration, System.Action onComplete)
    {
        float timer = duration;
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            yield return null;
        }
        onComplete?.Invoke();
    }
}
