using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 5;
    
    [SerializeField]
    private float deadZone = -45;

    void Update()
    {
        transform.position += (Vector3.left * movementSpeed) * Time.deltaTime;
        if(transform.position.x < deadZone){
            Destroy(gameObject);
        }
    }
}
