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

            Debug.Log("i'm falliiiiing!!");
            StartCoroutine (FallEnd());           
        }
        //C'est pénible, mais c'est ainsi dans unity, pour retarder une execution
        // il faut créer une fonction de type "IEnumerator"
        // c'est comme un delay (de 4secondes) [si dessous]
        IEnumerator FallEnd () {
            yield return new WaitForSeconds (4f);
            isFalling = false;

            Debug.Log ("Well, finally it's ok, i'm still alive");
        }
}
