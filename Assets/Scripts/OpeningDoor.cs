using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour
{
    public GameObject lockdoor;
    public Animator door;

    public void openDoor()
    {
        if(GameManager.keyInHole == true)
        {
            door = GetComponent<Animator>();
            door.SetBool("RotationPorte", true);
        }

    }
}
