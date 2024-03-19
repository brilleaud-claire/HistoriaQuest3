using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour
{
    public GameObject lockdoor;
    public void keyInHole()
    {
        if (GameManager.WinScenario == true)
        {
            GameManager.keyInHole = true;
        }
    }

    public void openDoor()
    {
        lockdoor.GetComponent<BoxCollider>().enabled = true;
    }
}
