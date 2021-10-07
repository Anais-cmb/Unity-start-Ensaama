using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CroneChildCloner : MonoBehaviour
{
    public int numberOfClones = 10;

    // Update is called once per frame
    void Update()
    {
        GameObject clone = Instantiate(gameObject, transform.parent);
        Destroy(clone.GetComponent<CrownChildCloner>());
        float yAngle = Random.Range(0f,360f);
        clone.transform.Rotate(0, yAngle, 0);
    }
}
