using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    [SerializeField]
    Text playerLifeText;

    static PlayerLives instance = null;

    int numberOfLivesRemaining;
    public int NumberOfLivesRemaining
    {
        get
        {
            return numberOfLivesRemaining;
        }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        numberOfLivesRemaining = 3;
        UpdateText();
    }

    public void LoseLife()
    {
        numberOfLivesRemaining--;
        UpdateText();
    }

    public void GainLife()
    {
        numberOfLivesRemaining++;
        UpdateText();
    }

    void UpdateText()
    {
        playerLifeText.text = "Lives: " + numberOfLivesRemaining;
    }
}
