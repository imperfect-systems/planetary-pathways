using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float movementSpeed = 5;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * movementSpeed) * Time.deltaTime;
        if(transform.position.x < deadZone){
            Destroy(gameObject);
        }
    }
}