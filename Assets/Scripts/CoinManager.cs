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
                var go = new GameObject(name: typeof(CoinManager).Name);
                instance = go.AddComponent<CoinManager>();
                
            }

            return instance;
        }
    }


    public int CoinCount { get; private set; }

    public int savedCoinCount;

    public int coinsInLevel;

    public int collectedCoinsInLevel;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
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
