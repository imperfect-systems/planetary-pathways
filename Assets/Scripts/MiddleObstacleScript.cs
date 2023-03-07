using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleObstacleScript : MonoBehaviour
{
    public LogicScript logic;

    void Start(){
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerExit2D(Collider2D collision){
       
        if(collision.gameObject.GetComponent<ShipScript>().shipIsAlive && collision.gameObject.layer == 3){
            logic.addScore(1);
        }
    }
}
