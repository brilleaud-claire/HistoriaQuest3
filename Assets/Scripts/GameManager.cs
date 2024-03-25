using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool SacreSuccess = false;
    public static bool SalonSuccess = false;
    public static bool GuillotineSuccess = false;
    public static bool WinScenario = false;
    public static bool LooseScenario = false;
    public static float timePassed;
    public GameObject key;
    public static bool keyInHole = false;
    public static float counterTime = 1800.0f;

    //public Text Menu;
    void Start()
    {
        
        //Menu.text = "System ERROR : please find a solution before the time is up, or you will be stuck here";
    }

    // Update is called once per frame
    void Update()
    {
        timePassed = StaticVar.num;
        if (counterTime > 0)
        {
            counterTime = 1800 - timePassed;

            if (SacreSuccess == true && SalonSuccess == true && GuillotineSuccess == true)
            {
                WinScenario = true;
                key.SetActive(true);
            }
        }
        else
        {
            counterTime = 0;
            LooseScenario = true;
        }
    }
}
