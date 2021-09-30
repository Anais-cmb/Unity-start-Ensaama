using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneOnClicks : MonoBehaviour
{
    public int numberOfClones = 3 ;

    private void OnMouseDown() {
        // La Mort !
        // Destroy(gameObject); ou on peut faire Destroy( object, float(nb à virgule) f(délais en frame));

        // La vie!
        for (int i = 0; i < numberOfClones; i = i + 1){
            GameObject clone= Instantiate(gameObject);
            Destroy(clone, 3f);
        }
        
    }
}
