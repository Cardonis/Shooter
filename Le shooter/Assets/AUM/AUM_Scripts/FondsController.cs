using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondsController : MonoBehaviour
{
    public GameObject player;

    public GameObject fondPrefab;

    public GameObject firstFond;
    public GameObject secondFond;
    public GameObject thirdFond;

    // Start is called before the first frame update
    void Start()
    {
        firstFond = fondPrefab;
        secondFond = fondPrefab;
        thirdFond = fondPrefab;
    }

    // Update is called once per frame
    void Update()
    {
        if(secondFond.transform.position.y + 3 < player.transform.position.y)
        {

        }
    }
}
