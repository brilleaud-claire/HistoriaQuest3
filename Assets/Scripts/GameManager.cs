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
    public static float time;
    public GameObject key;
    public static bool keyInHole = false;


    public Text Menu;
    void Start()
    {
        time = 0;
        Menu.text = "System ERROR : please find a solution before the time is up, or you will be stuck here";
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        if (SacreSuccess && SalonSuccess && GuillotineSuccess)
        {
            WinScenario = true;
            key.SetActive(true);
        }
    }
}
