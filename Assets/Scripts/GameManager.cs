using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool SacreSuccess = false;
    public static bool SalonSuccess = false;
    public static bool GuillotineSuccess = false;
    public static bool WinScenario = false;
    public static bool LooseScenario = false;
    public static float timePassed;
    public static string answer = "Josephine";
    public static bool goodAnswer = false;
    public GameObject key;
    public static bool keyInHole = false;
    public static float counterTime = 1800.0f;
    public GameObject menuFin;

    
    // Update is called once per frame
    void Start()
    {
        menuFin.SetActive(false);
    }
    void FixedUpdate()
    {
        timePassed = timePassed + Time.deltaTime;
        
        if (counterTime > 0)
        {
            counterTime = 1800 - timePassed;

            if (SacreSuccess == true && SalonSuccess == true && GuillotineSuccess == true)
            {
                menuFin.SetActive(true);
                if(goodAnswer == true)
                {
                    WinScenario = true;
                    key.SetActive(true);
                }
            }
        }
        else
        {
            counterTime = 0;
            LooseScenario = true;
            StartCoroutine(LooseScenarioScene());
        }
    }
    IEnumerator LooseScenarioScene()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("EcranAccueil");
    }

}
