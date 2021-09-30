using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    public Transform target;
    public bool isFalling = false;
    // Start is called before the first frame update
    void Start()
    {   
    }
    // Update is called once per frame
    void Update()
    {
       if (target != null) {
           if (isFalling == false){
            transform.LookAt(target);
           }
        }         
    }
        void OnMouseDown() {

            isFalling = true;
            Rigidbody body = gameObject.AddComponent<Rigidbody>();

            // "traînée angulaire, c-à-d la friction associée à la rotation
            // 0.05 par défaut, nous mettons donc 0.2f pour ralentir les yeux.
            body.angularDrag = 0.2f;            
        }

        
}
