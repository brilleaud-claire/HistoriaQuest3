using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.keyInHole == true)
        {
            StartCoroutine(openStart());
        }
    }
    IEnumerator openStart()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("EcranAccueil");
    }
    
}
