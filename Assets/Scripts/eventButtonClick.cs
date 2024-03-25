using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text buttonText;
    public TMP_Text SearchBarText;

    public void OnEventClick()
    {
        string s = buttonText.text;
        SearchBarText.text = s;
    }

}
