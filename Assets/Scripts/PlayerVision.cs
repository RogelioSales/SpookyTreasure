using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    //For testing vision
    [SerializeField]
    Camera cam;

    [SerializeField]
    float visionAngle = 15.0f;

    List<GameObject> enemiesList;

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

        foreach (var enemy in enemiesList)
        {
            enemyDirection = enemy.transform.position - this.gameObject.transform.position;
            enemyAngle = Vector3.Angle(enemyDirection, lookPos);

            if (enemyAngle <= visionAngle)
            {
                enemy.GetComponent<EnemyMovement>().CanBeSeen = true;
                canSeeEnemy = true; //for testing
            }
            else
            {
                enemy.GetComponent<EnemyMovement>().CanBeSeen = false;
                canSeeEnemy = false; //for testing
            }
        }

        //for testing
        if (canSeeEnemy)
        {
            //Debug.Log("I can see an enemy!");
            cam.backgroundColor = Color.red;
        }
        else
        {
            //Debug.Log("I can't see an enemy!");
            cam.backgroundColor = Color.blue;
        }
    }
}
