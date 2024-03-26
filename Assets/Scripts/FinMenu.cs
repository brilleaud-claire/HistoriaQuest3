using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinMenu : MonoBehaviour
{
    public Button okButton;
    public TMP_Text Result;
    

    IEnumerator waitTime()
    {
        Result.color = Color.green;
        okButton.GetComponent<Image>().color = Color.green;
        yield return new WaitForSeconds(2);
    }

    public void MenuFin()
    {
        if (Result.text == GameManager.answer)
        {
            StartCoroutine(waitTime());
            GameManager.goodAnswer = true;
        }
    }

   
}
