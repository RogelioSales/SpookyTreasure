using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    private static CoinManager instance;

    public static CoinManager Instance
    {
        get
        {
            if (instance == null)
            {
                var gameObject = new GameObject(name: typeof(CoinManager).Name);
                instance = gameObject.AddComponent<CoinManager>();
                DontDestroyOnLoad(gameObject);
            }

            return instance;
        }
    }


    public static int CoinCount { get; private set; }

    public static int savedCoinCount;

    public static int coinsInLevel;

    public static int collectedCoinsInLevel;

    private void Start()
    {
        Instance.FindAllCoinsInLevel();
    }


    public void AddCoin()
    {
        CoinCount++;
        collectedCoinsInLevel++;
    }

    public void ResetCoinCount()
    {
        CoinCount = 0;
    }

    public void ResetLevelCoinCount()
    {
        collectedCoinsInLevel = 0;
    }

    public void SaveCoinCount()
    {
        savedCoinCount = CoinCount;
    }

    public void ResetToSavedCoinCount()
    {
        CoinCount = savedCoinCount;
    }

    public void FindAllCoinsInLevel()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        coinsInLevel = coins.Length;
    }

}
