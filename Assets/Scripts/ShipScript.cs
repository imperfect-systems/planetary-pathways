using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipScript : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D shipRigidBody;

    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private ParticleSystem thruster;

    [SerializeField]
    private ParticleSystem explosion;

    [SerializeField]
    private float thrustPower = 10;

    // TODO: make this private when the obstacle passed event has been implemented
    public bool shipIsAlive = true;

    private LogicScript logic;
    
    void Start(){
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    void Update()
    {
        if(!Screen.safeArea.Contains(mainCamera.WorldToScreenPoint(transform.position))){
            logic.gameOver();
        }
    }

    public void Thrust(){
        if(shipIsAlive){
            shipRigidBody.velocity = Vector2.up * thrustPower;
            thruster.Play();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        shipIsAlive = false;
        explosion.transform.position = transform.position;
        explosion.Play();
        Destroy(gameObject);
        logic.gameOver();
    }
   
}
