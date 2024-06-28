using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isRunning = false;

    private void Update()
    {
        if (isRunning)
        {
            float timeElapsed = Time.time - startTime;
            float minutes = Mathf.Floor(timeElapsed / 60);
            float seconds = Mathf.Floor(timeElapsed % 60f);
            float milliseconds = (timeElapsed * 100) % 100f;
            timerText.text = $"{minutes}:{seconds}.{milliseconds}";
        }
    }

    public void StartTimer()
    {
        startTime = Time.time;
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}