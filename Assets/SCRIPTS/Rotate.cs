using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3();
    // Update is called once per frame
    void Update()
    {
        transform.rotate(rotationSpeed * Time.deltaTime);
    }
}
