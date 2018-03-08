using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CoinManager.Instance.SaveCoinCount();
        CoinManager.Instance.ResetLevelCoinCount();
        SceneManager.LoadScene("Level2");
    }
}
