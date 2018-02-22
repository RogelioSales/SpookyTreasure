using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField]
    float movementSpeed;

    [SerializeField]
    Transform Player;

 

    // Update is called once per frame
    void Update ()
    {
       
            float step = movementSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Player.position, step);
       
    }
}
