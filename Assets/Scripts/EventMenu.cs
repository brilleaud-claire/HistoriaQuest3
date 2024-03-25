using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class EventMenu : MonoBehaviour
{
    
    public GameObject Content;
    public GameObject[] Element;
    public GameObject SearchBar;
    public int totalElement;
    public Color32 c;
    public TMP_Text answer;
    public GameObject keyboard;


    void Start()
    {
        keyboard.SetActive(false);
        totalElement = Content.transform.childCount;
        Element = new GameObject[totalElement];
        for(int i =0; i<totalElement; i++)
        {
            Content.transform.GetChild(i).gameObject.SetActive(false);
            Element[i] = Content.transform.GetChild(i).gameObject;
        }

    }
    public void OpenKeyboard()
    {
        keyboard.SetActive(true);
    }
    public void CloseKeyboard()
    {
        keyboard.SetActive(true);
    }
    public void Search()
    {
        /*
        if (answer.text!= ". . . . . . . . . . . . . . . . . . . . . . .")
        {
            answer.color = c;
            answer.text = ". . . . . . . . . . . . . . . . . . . . . . .";
        }*/
       
        string SearchText = SearchBar.GetComponent<TMP_InputField>().text;
        int searchTxtlenght = SearchText.Length;
        int searchedElements = 0;
        List <GameObject> ResultElementWin = new List<GameObject> { };
        List<GameObject> ResultElementFal = new List<GameObject> { };
        foreach (GameObject ele in Element)
        {
            ele.SetActive(false);
            searchedElements += 1;
            if (ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Length >= searchTxtlenght && searchTxtlenght != 0)
            {
                for(int i = 0; i< ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Length- searchTxtlenght-1; i++)
                {
                    if (SearchText.ToLower() == ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Substring(i, searchTxtlenght).ToLower())
                    {
                        ele.SetActive(true);
                        ResultElementWin.Add(ele);
                    }
                    else
                    {
                        ResultElementFal.Add(ele);
                    }
                    
                }
                
            }
        }
        /*GameObject a = ResultElementWin[0];
        Content.Equals(null);
        for (int i = 0; i < ResultElementWin.Count; i++)
        {
            Content.AddComponent<Component>(a);
            Element[i] = Content.transform.GetChild(i).gameObject;
        }*/

    }
    
    
}
