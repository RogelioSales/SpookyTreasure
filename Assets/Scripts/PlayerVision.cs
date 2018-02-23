using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    [SerializeField]
    Camera cam;
    
    List<GameObject> enemiesList;

    // For testing only
    Color blue = Color.blue;
    Color red = Color.red;

    Vector3 enemyDirection;
    float enemyAngle;

    float visionAngle = 80.0f;
    bool canSeeEnemy = false;

    void Start()
    {
        enemiesList = new List<GameObject>();

        enemiesList.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
    }

    void Update()
    {
        // Just checking to see if the player can see ANY enemy
        // Only for testing
        foreach (var enemy in enemiesList)
        {
            enemyDirection = enemy.transform.position - this.gameObject.transform.position;
            enemyAngle = Vector3.Angle(enemyDirection, this.gameObject.transform.up);

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
            cam.backgroundColor = red;
        }
        else
        {
            cam.backgroundColor = blue;
        }
    }
}
