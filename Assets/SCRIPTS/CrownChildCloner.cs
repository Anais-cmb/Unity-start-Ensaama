using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CroneChildCloner : MonoBehaviour
{
    public int numberOfClones = 10;

    // Update is called once per frame
    void Start(){

        for (int i = 0; i < numberOfClones; i = i + 1){
            MakeAClone();
        }
    }

    void MakeAClone() {
        GameObject clone = Instantiate(gameObject, transform.parent);

        // IL FAUT DETRUIRE LE SCRIPT SUR L ENFANT !!!
        // Sans cela celui se clonera à son tour,puis son enfant aussi, puis le petit-enfant etc..
        Destroy(clone.GetComponent<CrownChildCloner>());

        float yAngle = Random.Range(0f,360f);
        clone.transform.Rotate(0, yAngle, 0);

        // Changeons la vitesse de rotation du clone
        Rotate rotate = clone.GetComponent<Rotate>();
        rotate.rotationSpeed = new Vector3(
            0f, 
            Random.Range(20f, 30f), 
            0f
        );

        // Changeons la taille de l'enfant du clone
        clone.transform.GetChild(0).localScale = Vector3.one * Random.range(0.2f, 1f) ;
    }
}


