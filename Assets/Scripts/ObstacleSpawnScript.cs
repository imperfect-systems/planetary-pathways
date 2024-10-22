using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;

    [SerializeField] private float spawnRate = 2;

    [SerializeField] private float heightOffset = 5;

    private float timer;

    void Start()
    {
        spawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer += Time.deltaTime;
        }
        else {
            spawnObstacle();
            timer = 0;
        }
        
    }

    void spawnObstacle(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 newPosition = new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),transform.position.z);

        Instantiate(obstacle, newPosition, transform.rotation);
    }
}
 