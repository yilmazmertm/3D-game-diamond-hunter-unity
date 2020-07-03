using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 diffVector;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
        diffVector = player.position - transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.position - diffVector;
    }
}
