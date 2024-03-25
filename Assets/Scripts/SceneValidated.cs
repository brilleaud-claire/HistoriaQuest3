using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneValidated : MonoBehaviour
{
    // Start is called before the first frame update
    public string toSceneName;
    public string sceneName;
    public string lieuAnswer;
    public Button okButtonLieu;
    public TMP_Text ResultLieu;

    IEnumerator waitTime()
    {

        
            ResultLieu.color = Color.green;
            okButtonLieu.GetComponent<Image>().color = Color.green;
            yield return new WaitForSeconds(2);


    }
    
    public void SucessScene()
    {
        if (ResultLieu.text == lieuAnswer)
        {
            StartCoroutine(waitTime());
            SceneManager.LoadScene(toSceneName);
            if (sceneName == "Sacre")
            {
                GameManager.SacreSuccess = true;
            }
            else if (sceneName == "SalonMondain")
            {
                GameManager.SalonSuccess = true;
            }
            else if (sceneName == "Robespierre")
            {
                GameManager.GuillotineSuccess = true;
            }
        }
        else
        {
            ResultLieu.color = Color.red;
        }


    }
}
