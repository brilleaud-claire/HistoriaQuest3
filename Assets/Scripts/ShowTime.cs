using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowTime : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text timeTxt;

    // Update is called once per frame
    void Update()
    {
       
        if (GameManager.LooseScenario == false)
        {
            timeTxt.text = "Temps: " + GetTime(GameManager.counterTime);
        }
        else
        {
            timeTxt.text = "LOOSER";
        }
    }
    private static string GetTime(float timeInSeconds)
    {
        int minutes = ((int)timeInSeconds) / 60;
        int seconds = ((int)timeInSeconds) % 60;

        return minutes + ":" + ((seconds < 10) ? "0" + seconds : seconds.ToString());
    }
}
