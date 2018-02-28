﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    [SerializeField]
    float visionAngle = 15.0f;

    List<GameObject> enemiesList;

    // For testing only
    Color blue = Color.blue;
    Color red = Color.red;

    Vector3 enemyDirection;
    float enemyAngle;

    static Vector3 mousePosition;
    Vector3 WorldMousePosition;

    
    bool canSeeEnemy = false;

    void Start()
    {
        mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        enemiesList = new List<GameObject>();
        WorldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        enemiesList.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
    }

    void Update()
    {
        mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        WorldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 lookPos = WorldMousePosition - transform.position;
        // Just checking to see if the player can see ANY enemy
        // Only for testing
        foreach (var enemy in enemiesList)
        {
            enemyDirection = enemy.transform.position - this.gameObject.transform.position;
            //enemyAngle = Vector3.Angle(enemyDirection, this.gameObject.transform.up);
            enemyAngle = Vector3.Angle(enemyDirection, lookPos);

            if (enemyAngle <= visionAngle)
            {
                canSeeEnemy = true;
            }
            else
            {
                canSeeEnemy = false;
            }
        }

        if (canSeeEnemy)
        {
            Debug.Log("I can see an enemy!");
        }
        else
        {
            Debug.Log("I can't see an enemy!");
        }
    }
}