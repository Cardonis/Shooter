using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondsController : MonoBehaviour
{
    public Transform fonds;

    public GameObject player;

    public GameObject fondPrefab;

    public GameObject firstFond;
    public GameObject secondFond;
    public GameObject thirdFond;

    // Start is called before the first frame update
    void Start()
    {
        firstFond = Instantiate(fondPrefab, fonds);
        secondFond = Instantiate(fondPrefab, fonds);
        thirdFond = Instantiate(fondPrefab, fonds);

        firstFond.transform.position = new Vector2(secondFond.transform.position.x, transform.position.y);

        secondFond.transform.position = new Vector2(secondFond.transform.position.x, firstFond.transform.position.y + 9.95f);

        thirdFond.transform.position = new Vector2(secondFond.transform.position.x, secondFond.transform.position.y + 9.95f);

    }

    // Update is called once per frame
    void Update()
    {
        if(secondFond.transform.position.y + 6 < player.transform.position.y)
        {
            Cycle();
        }
    }

    void Cycle()
    {
        Destroy(firstFond);

        firstFond = secondFond;
        secondFond = thirdFond;

        thirdFond = Instantiate(fondPrefab, fonds);

        thirdFond.transform.position = new Vector2(secondFond.transform.position.x, secondFond.transform.position.y + 9.95f);

    }
}
