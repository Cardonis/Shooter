using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject win;

    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        win.SetActive(true);
    }

}
