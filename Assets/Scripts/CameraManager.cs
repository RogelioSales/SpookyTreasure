using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    void Update()
    {
        this.gameObject.transform.position = player.transform.position;
    }
}
