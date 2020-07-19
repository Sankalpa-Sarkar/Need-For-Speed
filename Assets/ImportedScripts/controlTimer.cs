using UnityEngine;
using System.Collections;

public class controlTimer : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "startRace")
        {
            setTimer(1);
        }

        if (other.gameObject.name == "finishRace")
        {
            setTimer(0);
        }

    }

    void setTimer(int t)
    {
        Timer playerTimer = this.GetComponent<Timer>();
        playerTimer.startTimer = t;
    }
}