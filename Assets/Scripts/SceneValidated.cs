using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneValidated : MonoBehaviour
{
    // Start is called before the first frame update
    public string toSceneName;
    public string sceneName;

    public void SucessScene()
    {

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
}
