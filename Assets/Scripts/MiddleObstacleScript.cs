using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleObstacleScript : MonoBehaviour
{
    private LogicScript logic;

    void Start(){
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerExit2D(Collider2D collision){
       
       // TODO: Change this to an event that the logic script can consume, then make the "shipIsAlive" variable private in the Ship logic
        if(collision.gameObject.GetComponent<ShipScript>().shipIsAlive && collision.gameObject.layer == 3){
            logic.addScore(1);
        }
    }
}
