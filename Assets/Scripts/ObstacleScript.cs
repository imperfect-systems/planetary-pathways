using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5;
    
    [SerializeField] private float deadZone = -45;


    void Start(){
        string stage = PlayerPrefs.GetString("planet");
        string spritePath = $"obstacles/obstacle-{stage}";
        swapObstacleSprite("Top Obstacle", spritePath);
        swapObstacleSprite("Bottom Obstacle", spritePath);
    }

    void Update()
    {
        transform.position += (Vector3.left * movementSpeed) * Time.deltaTime;
        if(transform.position.x < deadZone){
            Destroy(gameObject);
        }
    }

    void swapObstacleSprite(string name, string spritePath){
        GameObject obj = transform.Find(name).gameObject;
        SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>(spritePath);
    }
}
