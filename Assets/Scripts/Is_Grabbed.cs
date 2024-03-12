using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class Is_Grabbed : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject obj;
    bool IsGrabbing = false;
    private XRDirectInteractor interactor = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {

        interactor = GetComponent<XRDirectInteractor>();
        IsGrabbing = false;

    }
}
