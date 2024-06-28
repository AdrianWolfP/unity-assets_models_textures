using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    private Timer timer;

    private void Start()
    {
        timer = GameObject.FindGameObjectWithTag("Player").GetComponent<Timer>();
        timer.enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timer.enabled = true;
            timer.StartTimer();
        }
    }
}