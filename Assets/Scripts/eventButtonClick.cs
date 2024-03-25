using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text buttonText;
    public TMP_Text SearchBar;
    public TMP_Text Answer;
    public string answer;
    public void Start()
    {
    }

    public void OnEventClick()
    {

        string s = buttonText.GetComponent<TMP_Text>().text;
        answer = s;
        Answer.SetText(s);
    }

}
