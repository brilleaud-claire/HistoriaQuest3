using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    public void keyInHole()
    {
        if (GameManager.WinScenario == true)
        {
            GameManager.keyInHole = true;
        }
    }
}
