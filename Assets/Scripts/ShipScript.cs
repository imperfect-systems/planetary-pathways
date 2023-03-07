using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipScript : MonoBehaviour
{

    public Rigidbody2D shipRigidBody;
    public LogicScript logic;
    public float thrustPower = 10;
    public bool shipIsAlive = true;

    void Start(){
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    public void Thrust(){
        if(shipIsAlive){
            shipRigidBody.velocity = Vector2.up * thrustPower;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        shipIsAlive = false;
        logic.gameOver();
    }
   
}
