using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField]
    float movementSpeed;

    [SerializeField]
    float OutOfRangeNumber;

    [SerializeField]
    Transform Player;

    private float Range;

    // Update is called once per frame
    void Update ()
    {
        Range = Vector2.Distance(transform.position, Player.transform.position);
        if (Range < OutOfRangeNumber)
        {
            float step = movementSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Player.position, step);
        }
    }
}
