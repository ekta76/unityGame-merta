using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollecter : MonoBehaviour
{
    public int coins = 0;

    public Text coinsText;
    public GameObject objectToSpawn;
    public Transform parent;
    public Vector3 newPosition;
    public Quaternion newRotation;

    [SerializeField] AudioSource itemCollectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            itemCollectionSoundEffect.Play();
            coins++;
            coinsText.text = "Coins: " + coins + "/3";
            Destroy(collision.gameObject);

            if (coins == 3)
            {
                Instantiate(objectToSpawn, newPosition, newRotation, parent);
            }
        }
    }

}
