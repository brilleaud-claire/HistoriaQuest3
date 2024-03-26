using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinMenu : MonoBehaviour
{
    public Button okButton;
    public TMP_Text Result;
    public string reponseJoueur;
    public string reponseAttendue;
    string rep = GameManager.answer;

    IEnumerator waitTime()
    {
        Result.color = Color.green;
        okButton.GetComponent<Image>().color = Color.green;
        yield return new WaitForSeconds(2);
    }

    public void MenuFin()
    {
        reponseJoueur = Result.text.ToLower().Substring(0,Result.text.Length-1);
        print(reponseJoueur);
        reponseAttendue = GameManager.answer;
        if (reponseJoueur == rep.ToLower())
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
