using TMPro;
using UnityEngine;

public class ExitPoint : MonoBehaviour
{
    public TMP_Text messageText; // TextMeshPro UI

    public CountdownTimer timer; // Reference to timer script

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageText.text = "Congratulations! You reached the exit!";
            timer.StopTimer();
            Time.timeScale = 0f;
        }
    }
}
