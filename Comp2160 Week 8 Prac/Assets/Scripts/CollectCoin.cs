using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    //private GameManager myGameManager;
    // Start is called before the first frame update
    [SerializeField] private int playerNum;
    void Start()
    {
        //myGameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Coin c = other.GetComponent<Coin>();
            //myGameManager.AddToScore(c.getValue());
            other.gameObject.SetActive(false);

            ScoreKeeper.Instance.UpdateScore(playerNum, c.getValue());
        }

    }
}
