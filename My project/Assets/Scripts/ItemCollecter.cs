using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollecter : MonoBehaviour
{
    public int coins = 0;

    [SerializeField] private Text coinsText;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private GameObject spawnToObject;

    private void Start()
    {
        Instantiate(objectToSpawn, spawnToObject.transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins + "/3";

            if (coins == 3)
            {
                Instantiate(objectToSpawn, spawnToObject.transform);
            }

        }
    }
}
