using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinMenu : MonoBehaviour
{
    public Button okButton;
    public TMP_Text Result;
    public bool reponseJoueur;
    public string reponseAttendue;
    string rep = "Josephine";

    IEnumerator waitTime()
    {
        Result.color = Color.green;
        okButton.GetComponent<Image>().color = Color.green;
        yield return new WaitForSeconds(2);
    }

    public void MenuFin()
    {
        reponseJoueur = (Result.text.ToLower() == rep.ToLower());
        reponseAttendue = GameManager.answer;
        if (Result.GetComponent<TMP_Text>().text.ToLower() == rep.ToLower())
        {
            StartCoroutine(waitTime());
            GameManager.goodAnswer = true;
        }
        else
        {
            Result.color = Color.red;
        }
    }

   
}
