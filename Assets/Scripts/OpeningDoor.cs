using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour
{
    public GameObject door;
    public void keyInHole()
    {
        if (GameManager.WinScenario == true)
        {
            GameManager.keyInHole = true;
        }
    }
}
