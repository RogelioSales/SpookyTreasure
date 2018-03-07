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

    public void AddCoin()
    {
        CoinCount++;
    }

    public void ResetCoinCount()
    {
        CoinCount = 0;
    }

    public void SaveCoinCount()
    {
        savedCoinCount = CoinCount;
    }

    public void ResetToSavedCoinCount()
    {
        CoinCount = savedCoinCount;
    }


}
