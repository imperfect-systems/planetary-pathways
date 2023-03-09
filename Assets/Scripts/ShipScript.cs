using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipScript : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D shipRigidBody;

    [SerializeField]
    private ParticleSystem thruster;

    [SerializeField]
    private float thrustPower = 10;

    public bool shipIsAlive = true;

    public LogicScript logic;
    
    
    

    void Start(){
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    public void Thrust(){
        if(shipIsAlive){
            shipRigidBody.velocity = Vector2.up * thrustPower;
            if(!thruster.isPlaying){
                thruster.Play();
            }
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        shipIsAlive = false;
        logic.gameOver();
    }
   
}
