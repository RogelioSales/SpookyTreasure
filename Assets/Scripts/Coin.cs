using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public static int CoinCount { get; private set; }

    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;


    private void Start()
    {
        CoinCount = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CoinCount++;
            Debug.Log("Touched the Coin! coinCount is " + CoinCount);
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;


        }


    }
}
