using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Timer timer; // Reference to the Timer script
    public Text timerText; // Reference to the timer text component

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has entered the trigger
        if (other.gameObject.CompareTag("Player"))
        {
            // Stop the timer
            timer.StopTimer();

            // Increase the font size and change the color to green
            timerText.fontSize = 60; // You can adjust this value to your liking
            timerText.color = Color.green;
        }
    }
}