using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinMenu : MonoBehaviour
{
    public Button okButton;
    public TMP_Text Result;
    public string answer;

    IEnumerator waitTime()
    {
        Result.color = Color.green;
        okButton.GetComponent<Image>().color = Color.green;
        yield return new WaitForSeconds(2);
    }

    public void MenuFin()
    {
        if (Result.text == answer)
        {
            StartCoroutine(waitTime());
        }
    }

   
}
