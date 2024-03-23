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
    public string goodDate;
    public TMP_Text dateResult;
    public Button okButton;

    void Start()
    {
        secondMenu.SetActive(false);
        //firstMenu.SetActive(true);
    }
    
    IEnumerator waitTime()
    {
        dateResult.color = Color.green;

        okButton.GetComponent<Image>().color = Color.green;
        yield return new WaitForSeconds(2);
        secondMenu.SetActive(true);
        firstMenu.SetActive(false);
    }
    public void SwitchMenus()
    {
      
        if (dateResult.text == goodDate)
        {
            StartCoroutine(waitTime());
        }
        else
        {
            dateResult.text = "1...";
            dateResult.color = Color.red;
        }
        
    }
}
