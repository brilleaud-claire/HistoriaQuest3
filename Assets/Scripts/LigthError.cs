using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthError : MonoBehaviour
{
    Light testLight;
    // Start is called before the first frame update
    void Start()
    {
        testLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new NotImplementedException();
    }

    IEnumerable Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            testLight.enabled = !testLight.enabled;
        }
    }
    
}
