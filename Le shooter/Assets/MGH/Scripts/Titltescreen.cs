using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titltescreen : MonoBehaviour
{
    public GameObject pressStart;

    void Start()
    {
        StartCoroutine(Clignotement());
    }
   
    void Update()
    {

       if (Input.anyKey == true)
        {
            SceneManager.LoadScene(2);
        }
    }
    IEnumerator Clignotement()
    {

        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            pressStart.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            pressStart.SetActive(false);
        }
    }
}
