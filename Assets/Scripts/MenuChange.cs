using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuChange : MonoBehaviour
{
    public GameObject firstMenu;
    public GameObject secondMenu;
    public GameObject thirdMenu;
    public TMP_Text ResultEvent;
    public Button okButtonEvent;
    public TMP_Text ResultDate;
    public Button okButtonDate;
    public string eventAnswer;
    public string dateAnswer;
    void Start()
    {
        
        secondMenu.SetActive(false);
        thirdMenu.SetActive(false);
        //firstMenu.SetActive(true);
    }
    
    IEnumerator waitTime(string s)
    {
        
        if(s == "EventToDate")
        {
            ResultEvent.color = Color.green;
            okButtonEvent.GetComponent<Image>().color = Color.green;
            yield return new WaitForSeconds(2);
            secondMenu.SetActive(true);
            firstMenu.SetActive(false);
        }
        else if (s == "DateToLieu")
        {
            ResultDate.color = Color.green;
            okButtonDate.GetComponent<Image>().color = Color.green;
            yield return new WaitForSeconds(2);
            thirdMenu.SetActive(true);
            secondMenu.SetActive(false);
        }
     
        
    }
    public void SwitchMenusDateToLieu()
    {
  

        if (ResultDate.text == dateAnswer)
        {
            StartCoroutine(waitTime("DateToLieu"));
        }
        else
        {
            ResultDate.text = "1...";
            ResultDate.color = Color.red;
        }
        
    }
    public void SwitchMenusEventToDate()
    {

        if (ResultEvent.text == eventAnswer)
        {
            StartCoroutine(waitTime("EventToDate"));
        }
        else
        {
            
            ResultEvent.color = Color.red;
        }

    }
    
}
