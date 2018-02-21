﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour {

    Text coinCountText;

    // Use this for initialization
    void Start()
    {
        coinCountText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coinCountText.text = string.Format("Coins: {0}", Coin.CoinCount);
    }
}
