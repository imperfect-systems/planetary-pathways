using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipScript : MonoBehaviour
{

    public Rigidbody2D shipRigidBody;
    public float thrustPower = 10;

    public void Thrust(){
        shipRigidBody.velocity = Vector2.up * thrustPower;
    }
}
