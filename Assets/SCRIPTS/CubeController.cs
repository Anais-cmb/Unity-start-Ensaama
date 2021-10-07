using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 10f;
    public float jumpAngularSpeed = 5f;
    public float jumpCoolDown = 0f;
    public Rigidbody body;

    void Start() {
        body = GetComponent<Rigidbody>();

        if (body == null) {
            Debug.LogError("Il n'y a pas de RigidBody sur le GameObject. Pense à en ajouter un.");
            Debug.Break();
        }
    }

    void UpdateMove() {
        Vector3 move = new Vector3();
        move.x = speed * Input.GetAxis("Horizontal");
        move.y = body.velocity.y;
        move.z = speed * Input.GetAxis("Vertical");
        
        body.velocity = move;
    }
    void UpdateJump (){
        
        jumpCoolDown = jumpCoolDown - Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && jumpCoolDown <= 0) {
            jumpCoolDown = 1f;
            Vector3 move = body.velocity;
            move.y = jumpSpeed;
            body.velocity = move;

            //vitesse de rotation aléatoire sur le cube
            body.angularVelocity = Random.onUnitSphere * jumpAngularSpeed;
        }
    }

    void Update(){
        UpdateMove();
        UpdateJump();
    }

}
