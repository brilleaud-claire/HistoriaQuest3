using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TypeText : MonoBehaviour
{
    // Start is called before the first frame update
    string originalTexte;
    TMP_Text uiText;
    public float delay = 0.05f;
    private void Awake()
    {
        uiText = GetComponent<TMP_Text>();
        originalTexte = uiText.text;
        uiText.text = null;
        StartCoroutine(ShowLetterByLetter());
    }
    IEnumerator ShowLetterByLetter()
    {
        yield return new WaitForSeconds(2.0f);
        for (int i=0; i<= originalTexte.Length; i++)
        {
            uiText.text = originalTexte.Substring(0, i);
            yield return new WaitForSeconds(delay);
        }
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Donjon");
    }
    
}
