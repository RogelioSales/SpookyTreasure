using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;

    [SerializeField]
    Transform Player;

    float distanceToPlayer;
    float step;

    void Update()
    {
        distanceToPlayer = Vector2.Distance(this.transform.position, Player.position);
        step = movementSpeed * Time.deltaTime * (1/distanceToPlayer);

        transform.position = Vector3.MoveTowards(transform.position, Player.position, step);
    }
}
