using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text timerText;   // TextMeshPro UI
    public TMP_Text messageText; // TextMeshPro UI
    public float timeRemaining = 60f;
    private bool timerIsRunning = true;

    void Start()
    {
        DisplayTime(timeRemaining);
    }

    void Update()
    {
        if (timerIsRunning && Time.timeScale > 0)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                DisplayTime(timeRemaining);
                messageText.text = "Time's Up!";
                Time.timeScale = 0f;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StopTimer()
    {
        timerIsRunning = false;
    }
}
